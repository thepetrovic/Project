using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_slozi_sliku
{
    internal class UpitiNadBazom
    {
        public SQLiteConnection konekcija;
        public UpitiNadBazom()
        {
            konekcija=new SQLiteConnection("Data Source=database.sqlite3");
            if(!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
            }
        }
        public void UpisiRezultat(string ime,string prezime,int broj_poteza,int vreme)
        {
            konekcija.Open();
            string upit = "insert into rezultati('ime','prezime','broj_poteza','vreme') values(@ime,@prezime,@broj_poteza,@vreme)";
            SQLiteCommand kom=new SQLiteCommand(upit,konekcija);
            kom.Parameters.AddWithValue("@ime", ime);
            kom.Parameters.AddWithValue("@prezime", prezime);
            kom.Parameters.AddWithValue("@broj_poteza",broj_poteza);
            kom.Parameters.AddWithValue("@vreme", vreme);
            var res=kom.ExecuteNonQuery();
            if (res < 0)
                MessageBox.Show("Rezultat nije unet");
            else
                MessageBox.Show("Rezultat je dodat");
            konekcija.Close();
        }
        public List<Osoba> DajRezultate1()
        {
            List<Osoba> osobe=new List<Osoba>();
            konekcija.Open();

            string upit = "select * from rezultati order by broj_poteza,vreme limit 10";
            SQLiteCommand kom=new SQLiteCommand(upit,konekcija);
            SQLiteDataReader red=kom.ExecuteReader();
            if(red.HasRows)
            {
                while(red.Read())
                {
                    int id = int.Parse(red["id"].ToString());
                    string ime = red["ime"].ToString();
                    string prezime = red["prezime"].ToString();
                    int broj_poteza = int.Parse(red["broj_poteza"].ToString());
                    int vreme = int.Parse(red["vreme"].ToString());
                    osobe.Add(new Osoba(id,ime,prezime,broj_poteza,vreme));
                }
            }
            konekcija.Close();
            return osobe;
        }

        public List<Osoba> DajRezultate2()
        {
            List<Osoba> osobe = new List<Osoba>();
            konekcija.Open();

            string upit = "select * from rezultati order by vreme,broj_poteza limit 10";
            SQLiteCommand kom = new SQLiteCommand(upit, konekcija);
            SQLiteDataReader red = kom.ExecuteReader();
            if (red.HasRows)
            {
                while (red.Read())
                {
                    int id = int.Parse(red["id"].ToString());
                    string ime = red["ime"].ToString();
                    string prezime = red["prezime"].ToString();
                    int broj_poteza = int.Parse(red["broj_poteza"].ToString());
                    int vreme = int.Parse(red["vreme"].ToString());
                    osobe.Add(new Osoba(id, ime, prezime, broj_poteza, vreme));
                }
            }
            konekcija.Close();
            return osobe;
        }
    }
}
