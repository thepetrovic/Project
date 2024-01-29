using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_slozi_sliku
{
    internal class Osoba
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public int broj_poteza { get; set; }
        public int vreme { get; set; }

        public Osoba(int id, string ime, string prezime, int broj_poteza, int vreme)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.broj_poteza = broj_poteza;
            this.vreme = vreme;
        }
    }
}
