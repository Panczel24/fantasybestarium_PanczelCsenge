using System;
using System.Collections.Generic;
using System.Text;

namespace fantasybestarium_PanczelCsenge
{
    internal class Szorny
    {
        private int id;
        private string nev;
        private int veszelyessegSzint;
        private string elohely;
        private string foGyengeseg;
        private string leggyakoribbZsakmany;
        private bool vezselyesE;

        public Szorny(int id, string nev, int veszelyessegSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool vezselyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegSzint = veszelyessegSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            this.leggyakoribbZsakmany = leggyakoribbZsakmany;
            this.vezselyesE = vezselyesE;
        }

        public int Id { get => id; }
        public string Nev { get => nev;  }
        public int VeszelyessegSzint { get => veszelyessegSzint; }
        public string Elohely { get => elohely; }
        public string FoGyengeseg { get => foGyengeseg; }
        public string LeggyakoribbZsakmany { get => leggyakoribbZsakmany; }
        public bool VezselyesE { get => vezselyesE; }
    }
}
