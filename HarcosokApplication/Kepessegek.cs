using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosokApplication
{
    class Kepessegek
    {
        int id;
        string nev;
        string leiras;
        int harcosok_id;

        public Kepessegek(int id, string nev, string leiras, int harcosok_id)
        {
            this.id = id;
            this.nev = nev;
            this.leiras = leiras;
            this.harcosok_id = harcosok_id;
        }

        public int Id { get => id; }
        public string Nev { get => nev;}
        public string Leiras { get => leiras;}
        public int Harcosok_id { get => harcosok_id;}

        public override string ToString()
        {
            return this.nev;
        }
    }
}
