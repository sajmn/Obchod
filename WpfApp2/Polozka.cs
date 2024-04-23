using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Polozka
    {
        public Polozka(int id, string nazev, string pocet, int cena)
        {
            Id = id;
            Nazev = nazev;
            Pocet = pocet;
            Cena = cena;
        }

        public int? Id { get; set; }
        public string Nazev { get; set; }
        public string Pocet { get; set; }

        public int Cena { get; set; }

        public override string ToString()
        {
            return $"{Nazev} {Pocet} {Cena.ToString()}";
        }

    }
}
