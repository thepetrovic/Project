
namespace Projekat_slozi_sliku
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucitaj_sliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nova_igra = new System.Windows.Forms.Button();
            this.broj_poteza = new System.Windows.Forms.Label();
            this.row3 = new System.Windows.Forms.RadioButton();
            this.row4 = new System.Windows.Forms.RadioButton();
            this.row5 = new System.Windows.Forms.RadioButton();
            this.broj_vrsta = new System.Windows.Forms.GroupBox();
            this.broj_kolona = new System.Windows.Forms.GroupBox();
            this.col5 = new System.Windows.Forms.RadioButton();
            this.col4 = new System.Windows.Forms.RadioButton();
            this.col3 = new System.Windows.Forms.RadioButton();
            this.kraj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.naziv_slike = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ime_igraca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime_igraca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj_potezaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vreme_u_sekundama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.broj_vrsta.SuspendLayout();
            this.broj_kolona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucitaj_sliku
            // 
            this.ucitaj_sliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucitaj_sliku.Location = new System.Drawing.Point(960, 23);
            this.ucitaj_sliku.Margin = new System.Windows.Forms.Padding(2);
            this.ucitaj_sliku.Name = "ucitaj_sliku";
            this.ucitaj_sliku.Size = new System.Drawing.Size(159, 29);
            this.ucitaj_sliku.TabIndex = 1;
            this.ucitaj_sliku.Text = "Ucitaj sliku";
            this.ucitaj_sliku.UseVisualStyleBackColor = true;
            this.ucitaj_sliku.Click += new System.EventHandler(this.ucitajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nova_igra
            // 
            this.nova_igra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nova_igra.Location = new System.Drawing.Point(967, 449);
            this.nova_igra.Margin = new System.Windows.Forms.Padding(2);
            this.nova_igra.Name = "nova_igra";
            this.nova_igra.Size = new System.Drawing.Size(159, 30);
            this.nova_igra.TabIndex = 2;
            this.nova_igra.Text = "Nova igra";
            this.nova_igra.UseVisualStyleBackColor = true;
            this.nova_igra.Click += new System.EventHandler(this.nova_igra_Click);
            // 
            // broj_poteza
            // 
            this.broj_poteza.AutoSize = true;
            this.broj_poteza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_poteza.Location = new System.Drawing.Point(963, 102);
            this.broj_poteza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.broj_poteza.Name = "broj_poteza";
            this.broj_poteza.Size = new System.Drawing.Size(106, 20);
            this.broj_poteza.TabIndex = 3;
            this.broj_poteza.Text = "Broj poteza:";
            // 
            // row3
            // 
            this.row3.AutoSize = true;
            this.row3.Location = new System.Drawing.Point(11, 17);
            this.row3.Margin = new System.Windows.Forms.Padding(2);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(32, 17);
            this.row3.TabIndex = 5;
            this.row3.TabStop = true;
            this.row3.Text = "3";
            this.row3.UseVisualStyleBackColor = true;
            this.row3.CheckedChanged += new System.EventHandler(this.Row_Col_Change);
            // 
            // row4
            // 
            this.row4.AutoSize = true;
            this.row4.Location = new System.Drawing.Point(10, 39);
            this.row4.Margin = new System.Windows.Forms.Padding(2);
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(32, 17);
            this.row4.TabIndex = 6;
            this.row4.TabStop = true;
            this.row4.Text = "4";
            this.row4.UseVisualStyleBackColor = true;
            this.row4.CheckedChanged += new System.EventHandler(this.Row_Col_Change);
            // 
            // row5
            // 
            this.row5.AutoSize = true;
            this.row5.Location = new System.Drawing.Point(10, 61);
            this.row5.Margin = new System.Windows.Forms.Padding(2);
            this.row5.Name = "row5";
            this.row5.Size = new System.Drawing.Size(32, 17);
            this.row5.TabIndex = 7;
            this.row5.TabStop = true;
            this.row5.Text = "5";
            this.row5.UseVisualStyleBackColor = true;
            this.row5.CheckedChanged += new System.EventHandler(this.Row_Col_Change);
            // 
            // broj_vrsta
            // 
            this.broj_vrsta.Controls.Add(this.row3);
            this.broj_vrsta.Controls.Add(this.row5);
            this.broj_vrsta.Controls.Add(this.row4);
            this.broj_vrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_vrsta.Location = new System.Drawing.Point(985, 201);
            this.broj_vrsta.Margin = new System.Windows.Forms.Padding(2);
            this.broj_vrsta.Name = "broj_vrsta";
            this.broj_vrsta.Padding = new System.Windows.Forms.Padding(2);
            this.broj_vrsta.Size = new System.Drawing.Size(110, 92);
            this.broj_vrsta.TabIndex = 8;
            this.broj_vrsta.TabStop = false;
            this.broj_vrsta.Text = "Broj vrsta";
            // 
            // broj_kolona
            // 
            this.broj_kolona.Controls.Add(this.col5);
            this.broj_kolona.Controls.Add(this.col4);
            this.broj_kolona.Controls.Add(this.col3);
            this.broj_kolona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_kolona.Location = new System.Drawing.Point(985, 326);
            this.broj_kolona.Margin = new System.Windows.Forms.Padding(2);
            this.broj_kolona.Name = "broj_kolona";
            this.broj_kolona.Padding = new System.Windows.Forms.Padding(2);
            this.broj_kolona.Size = new System.Drawing.Size(109, 88);
            this.broj_kolona.TabIndex = 9;
            this.broj_kolona.TabStop = false;
            this.broj_kolona.Text = "Broj kolona";
            // 
            // col5
            // 
            this.col5.AutoSize = true;
            this.col5.Location = new System.Drawing.Point(5, 63);
            this.col5.Margin = new System.Windows.Forms.Padding(2);
            this.col5.Name = "col5";
            this.col5.Size = new System.Drawing.Size(32, 17);
            this.col5.TabIndex = 2;
            this.col5.TabStop = true;
            this.col5.Text = "5";
            this.col5.UseVisualStyleBackColor = true;
            this.col5.CheckedChanged += new System.EventHandler(this.Row_Col_Change);
            // 
            // col4
            // 
            this.col4.AutoSize = true;
            this.col4.Location = new System.Drawing.Point(5, 41);
            this.col4.Margin = new System.Windows.Forms.Padding(2);
            this.col4.Name = "col4";
            this.col4.Size = new System.Drawing.Size(32, 17);
            this.col4.TabIndex = 1;
            this.col4.TabStop = true;
            this.col4.Text = "4";
            this.col4.UseVisualStyleBackColor = true;
            this.col4.CheckedChanged += new System.EventHandler(this.Row_Col_Change);
            // 
            // col3
            // 
            this.col3.AutoSize = true;
            this.col3.Location = new System.Drawing.Point(5, 18);
            this.col3.Margin = new System.Windows.Forms.Padding(2);
            this.col3.Name = "col3";
            this.col3.Size = new System.Drawing.Size(32, 17);
            this.col3.TabIndex = 0;
            this.col3.TabStop = true;
            this.col3.Text = "3";
            this.col3.UseVisualStyleBackColor = true;
            this.col3.CheckedChanged += new System.EventHandler(this.Row_Col_Change);
            // 
            // kraj
            // 
            this.kraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kraj.Location = new System.Drawing.Point(967, 583);
            this.kraj.Margin = new System.Windows.Forms.Padding(2);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(159, 29);
            this.kraj.TabIndex = 10;
            this.kraj.Text = "Kraj";
            this.kraj.UseVisualStyleBackColor = true;
            this.kraj.Click += new System.EventHandler(this.kraj_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.TabIndex = 11;
            // 
            // naziv_slike
            // 
            this.naziv_slike.AutoSize = true;
            this.naziv_slike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naziv_slike.Location = new System.Drawing.Point(964, 67);
            this.naziv_slike.Name = "naziv_slike";
            this.naziv_slike.Size = new System.Drawing.Size(77, 13);
            this.naziv_slike.TabIndex = 12;
            this.naziv_slike.Text = "Naziv slike: ";
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(995, 155);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(85, 29);
            this.timer.TabIndex = 13;
            this.timer.Text = "00:00:00";
            this.timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(993, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vreme igre: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime_igraca,
            this.prezime_igraca,
            this.broj_potezaa,
            this.vreme_u_sekundama});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(22, 635);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 190);
            this.dataGridView1.TabIndex = 19;
            // 
            // ime_igraca
            // 
            this.ime_igraca.HeaderText = "Ime";
            this.ime_igraca.Name = "ime_igraca";
            // 
            // prezime_igraca
            // 
            this.prezime_igraca.HeaderText = "Prezime";
            this.prezime_igraca.Name = "prezime_igraca";
            // 
            // broj_potezaa
            // 
            this.broj_potezaa.HeaderText = "Broj poteza";
            this.broj_potezaa.Name = "broj_potezaa";
            // 
            // vreme_u_sekundama
            // 
            this.vreme_u_sekundama.HeaderText = "Vreme u sekundama";
            this.vreme_u_sekundama.Name = "vreme_u_sekundama";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 85);
            this.button1.TabIndex = 20;
            this.button1.Text = "Prikazi najboljih 10  igraca po broju poteza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(500, 737);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 88);
            this.button2.TabIndex = 21;
            this.button2.Text = "Prikazi najboljih 10  igraca po vremenu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 837);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.naziv_slike);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.broj_kolona);
            this.Controls.Add(this.broj_vrsta);
            this.Controls.Add(this.broj_poteza);
            this.Controls.Add(this.nova_igra);
            this.Controls.Add(this.ucitaj_sliku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.broj_vrsta.ResumeLayout(false);
            this.broj_vrsta.PerformLayout();
            this.broj_kolona.ResumeLayout(false);
            this.broj_kolona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ucitaj_sliku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button nova_igra;
        private System.Windows.Forms.Label broj_poteza;
        private System.Windows.Forms.RadioButton row3;
        private System.Windows.Forms.RadioButton row4;
        private System.Windows.Forms.RadioButton row5;
        private System.Windows.Forms.GroupBox broj_vrsta;
        private System.Windows.Forms.GroupBox broj_kolona;
        private System.Windows.Forms.RadioButton col5;
        private System.Windows.Forms.RadioButton col4;
        private System.Windows.Forms.RadioButton col3;
        private System.Windows.Forms.Button kraj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label naziv_slike;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime_igraca;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime_igraca;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_potezaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn vreme_u_sekundama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

