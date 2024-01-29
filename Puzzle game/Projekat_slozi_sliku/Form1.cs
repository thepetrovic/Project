using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
namespace Projekat_slozi_sliku
{
    public partial class Form1 : Form
    {
        UpitiNadBazom baza=new UpitiNadBazom();
        WMPLib.WindowsMediaPlayer player=new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            init();
        }
        
        OpenFileDialog openfileDialog = null;
        Bitmap image=null;
        Image[,] images;
        PictureBox picBox = null;
        int broj_poteza1 = 0;
        MyPictureBox[,] boxes = null;
        private (int, int) empty;
        bool start = false;
        System.Timers.Timer startTimer;
        int h, m, s;
        
        private void init()
        {
            panel1.BackColor = Color.White;
            this.row3.Checked = true;
            this.col3.Checked = true;
            this.nova_igra.Enabled = false;
            generateBoxes(dajBrojVrsta(), dajBrojKolona());
            startTimer=new System.Timers.Timer();
            startTimer.Interval = 1000;
            startTimer.Elapsed += OnTimeEvent;
            player.URL = "Songg.mp3";
            player.controls.stop();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if(s==60)
                {
                    s = 0;
                    m += 1;
                }
                if(m==60)
                {
                    m = 0;
                    h += 1;
                }
                timer.Text = String.Format("{0}:{1}:{2}",h.ToString().PadLeft(2,'0'),m.ToString().PadLeft(2,'0'),s.ToString().PadLeft(2,'0'));
            }

            ));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            startTimer.Stop();
            Application.DoEvents();
        }

        private Bitmap CreateBitmap(Image image)
        {
            Bitmap bitmap = new Bitmap(this.panel1.Width, this.panel1.Height);
            Graphics objGraphics = Graphics.FromImage(bitmap);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, panel1.Width, panel1.Height));
            objGraphics.Flush();
            return bitmap;

        }
        private void ucitajSliku_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("button-click.wav");
            sound.PlaySync();
            init();
            if (openfileDialog == null)
                openfileDialog = new OpenFileDialog();
            
            openfileDialog.Filter = "bmp files (*.bmp)| *.bmp";
            openfileDialog.Title = "Ucitaj sliku";
            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                image= CreateBitmap(Image.FromFile(openfileDialog.FileName));

                if (picBox == null)
                {
                    picBox = new PictureBox();
                    picBox.Height = panel1.Height;
                    picBox.Width = panel1.Width;
                    //panel1.Controls.Add(picBox);
                }
                cropImage();
                picBox.Image = image;
                naziv_slike.Text = "Naziv slike: " + openfileDialog.SafeFileName;
                this.nova_igra.Enabled = true;
                
            }
            player.controls.play();
        }

        private int dajBrojVrsta()
        {
            if (row3.Checked) return 3;
            else if (row4.Checked) return 4;
            else return 5;
        }

        private int dajBrojKolona()
        {
            if (col3.Checked) return 3;
            else if (col4.Checked) return 4;
            else return 5;
        }
        private void generateBoxes(int h,int w)
        {
            boxes=new MyPictureBox[h,w];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    boxes[i,j]=new MyPictureBox();
                    boxes[i,j].BackColor=Color.White;
                    boxes[i, j].Width = this.panel1.Width / w - 1;
                    boxes[i,j].Height = this.panel1.Height / h - 1;
                    boxes[i,j].Parent = this.panel1;
                    boxes[i,j].Location = new Point(j*this.panel1.Width/w,i*this.panel1.Height/h);
                    panel1.Controls.Add(boxes[i, j]);
                    boxes[i,j].BringToFront();
                    boxes[i,j].DoubleClick+=new System.EventHandler(doubleClickBox);
                    boxes[i, j].realI = i;
                    boxes[i, j].realJ = j;
                    boxes[i, j].currentI = i;
                    boxes[i, j].currentJ = j;
                }
            }
                   
        }
        private void fillBoxes()
        {
            int h = boxes.GetLength(0);
            int w = boxes.GetLength(1);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    boxes[i, j].realI = i;
                    boxes[i, j].realJ = j;
                    boxes[i, j].Image = images[i, j];
                }
            }
        }
        private void cropImage()
        {
            if (image != null)
            {
                int h = boxes.GetLength(0);
                int w = boxes.GetLength(1);

                images = new Image[h, w];
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        this.images[i, j] = new Bitmap(boxes[i, j].Width, boxes[i, j].Height);
                        var graphics = Graphics.FromImage(this.images[i, j]);

                        graphics.DrawImage(image, new Rectangle(0, 0, this.boxes[i, j].Width, this.boxes[i, j].Height),
                        new Rectangle(j * this.image.Width / w, i * this.image.Height / h, this.image.Width / w, this.image.Height / h), GraphicsUnit.Pixel);
                        graphics.Dispose();
                    }
                }

                fillBoxes();
            }
        }
        public void shuffleImages()
        {
            Random random = new Random();
            int lengthRow = images.GetLength(1);

            for (int i = images.Length - 1; i > 0; i--)
            {
                int i0 = i / lengthRow;
                int i1 = i % lengthRow;

                int j = random.Next(i + 1);
                int j0 = j / lengthRow;
                int j1 = j % lengthRow;

                int temp = boxes[i0, i1].realI;
                boxes[i0, i1].realI = boxes[j0, j1].realI;
                boxes[j0, j1].realI = temp;

                int temp2 = boxes[i0, i1].realJ;
                boxes[i0, i1].realJ = boxes[j0, j1].realJ;
                boxes[j0, j1].realJ = temp2;

                Image temp3 = boxes[i0, i1].Image;
                boxes[i0, i1].Image = boxes[j0, j1].Image;
                boxes[j0, j1].Image = temp3;

                
            }

            empty = (random.Next(images.GetLength(0)), random.Next(images.GetLength(1)));
            boxes[empty.Item1, empty.Item2].Image = null;
        }
        private void nova_igra_Click(object sender, EventArgs e)
        {
            SoundPlayer sound=new SoundPlayer("button-click.wav");
            sound.PlaySync();
            start = true;
            broj_poteza1 = 0;
            this.broj_poteza.Text = "Broj poteza: " + broj_poteza1;
            cropImage();
            shuffleImages();
            h = 0;
            s = 0;
            m = 0;

            startTimer.Start();
            
        }
        private void clearBoxes()
        {
            if (boxes != null)
            {
                int h = boxes.GetLength(0);
                int w = boxes.GetLength(1);
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        panel1.Controls.Remove(boxes[i, j]);
                    }
                }
            }
        }

        private void Row_Col_Change(object sender, EventArgs e)
        {
            clearBoxes();
            generateBoxes(dajBrojVrsta(), dajBrojKolona());
            cropImage();
            if(startTimer != null)  
                startTimer.Stop();
        }

        private void kraj_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("button-click.wav");
            sound.PlaySync();
            startTimer.Stop();
            Application.DoEvents();
            this.Close();
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Osoba> osobe=new List<Osoba>();
            osobe = baza.DajRezultate1();
            dataGridView1.Rows.Clear();
            foreach(Osoba osoba in osobe)
            {
                DataGridViewRow red = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                red.Tag = osoba;
                red.Cells[0].Value = osoba.ime;
                red.Cells[1].Value = osoba.prezime;
                red.Cells[2].Value = osoba.broj_poteza;
                red.Cells[3].Value = osoba.vreme;
                dataGridView1.Rows.Add(red);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe = baza.DajRezultate2();
            dataGridView1.Rows.Clear();
            foreach (Osoba osoba in osobe)
            {
                DataGridViewRow red = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                red.Tag = osoba;
                red.Cells[0].Value = osoba.ime;
                red.Cells[1].Value = osoba.prezime;
                red.Cells[2].Value = osoba.broj_poteza;
                red.Cells[3].Value = osoba.vreme;
                dataGridView1.Rows.Add(red);
            }
        }

        

        public bool checkSolution()
        {
            int height = boxes.GetLength(0);
            int width = boxes.GetLength(1);
            images = new Image[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (boxes[i, j].currentI != boxes[i, j].realI || boxes[i, j].currentJ != boxes[i, j].realJ) return false;
                }
            }

            startTimer.Stop();
            string vreme= String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            
            DialogResult confirmResult1 = MessageBox.Show(String.Format("Uspesno si zavrsio igru u {0} poteza za {1} sekundi\n Da li zelis da sacuvas rezultat?",this.broj_poteza1,vreme),
            "Cuvanje rezultata",MessageBoxButtons.YesNo);
            if (confirmResult1 == DialogResult.Yes)
            {
                
                string message, title, ime, prezime;
                object myValue;

                message = "Unesi ime i prezime";
                title = "Podaci";
                ime = "Ime";
                prezime = "Prezime";
                char ch = ' ';
                myValue = Interaction.InputBox(message, title, ime +" "+ prezime);
                if ((string)myValue == "")
                {
                    myValue=ime+" "+prezime;
                    int broj_poteza = this.broj_poteza1;
                    int vreme1 = int.Parse(vreme.Split(':')[0]) * 3600 + int.Parse(vreme.Split(':')[1]) * 60 + int.Parse(vreme.Split(':')[2]);
                    baza.UpisiRezultat(ime, prezime, broj_poteza, vreme1);
                   
                }
                else if(myValue.ToString().Count(f=>(f==ch))==1)
                {
                    ime=myValue.ToString().Split(' ')[0];
                    prezime=myValue.ToString().Split(' ')[1];
                    int broj_poteza = this.broj_poteza1;
                    int vreme1 = int.Parse(vreme.Split(':')[0]) * 3600 + int.Parse(vreme.Split(':')[1]) * 60 + int.Parse(vreme.Split(':')[2]);
                    baza.UpisiRezultat(ime, prezime, broj_poteza, vreme1);
                
                }
                else
                {
                    ime = myValue.ToString();
                    prezime = "";
                    int broj_poteza = this.broj_poteza1;
                    int vreme1 = int.Parse(vreme.Split(':')[0]) * 3600 + int.Parse(vreme.Split(':')[1]) * 60 + int.Parse(vreme.Split(':')[2]);
                    baza.UpisiRezultat(ime, prezime, broj_poteza, vreme1);
                   
                }

            }
            
            DialogResult confirmResult = MessageBox.Show(String.Format("Da li zelis ponovo da igras?"),
                "Ponovi igru?",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                start = false;
                init();
                
                h = 0;
                s = 0;
                m = 0;
                timer.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                broj_poteza1 = 0;
                this.broj_poteza.Text = "Broj poteza: " + broj_poteza1;
                naziv_slike.Text = "Naziv slike: ";
            }
            else
            {
                this.Close();
            }

            return true;
        }
        private void doubleClickBox(object sender, EventArgs e)
        {
            if (!start) return;
            MyPictureBox box = (MyPictureBox)sender;      
            int[] possibleI = new int[] { box.currentI + 1, box.currentI - 1 };
            int[] possibleJ = new int[] { box.currentJ + 1, box.currentJ - 1 };    
            if ((possibleI.Contains(empty.Item1) && box.currentJ == empty.Item2) ^ (possibleJ.Contains(empty.Item2) && box.currentI == empty.Item1))
            {
                int i1 = box.currentI;
                int j1 = box.currentJ;
                int i2 = empty.Item1;
                int j2 = empty.Item2;
                Debug.WriteLine("Moving");
                Swap(ref boxes[i1, j1].realI, ref boxes[i2, j2].realI);
                Swap(ref boxes[i1, j1].realJ, ref boxes[i2, j2].realJ);
                Image temp = boxes[i1, j1].Image;
                boxes[i1, j1].Image = boxes[i2, j2].Image;
                boxes[i2, j2].Image = temp;
                empty = (box.currentI, box.currentJ);
                this.broj_poteza1++;
                this.broj_poteza.Text = "Broj poteza : " + this.broj_poteza1;
                checkSolution();
            }
        }


    }
}
