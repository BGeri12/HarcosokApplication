using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosokApplication
{
    class Harcosok
    {
        int id;
        string nev;
        DateTime letrehozas;

        public Harcosok(int id, string nev, DateTime letrehozas)
        {
            this.id = id;
            this.nev = nev;
            this.letrehozas = letrehozas;
        }

        public int Id { get => id;}
        public string Nev { get => nev;}
        public DateTime Letrehozas { get => letrehozas;}

        public override string ToString()
        {
            return this.nev + this.letrehozas;
        }

    }
}
