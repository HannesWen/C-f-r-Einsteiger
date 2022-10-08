using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_für_Einsteiger
{
    class Geländewagen : Auto
    {
        bool Allradantrieb { get;set; }

        public Geländewagen(int ps, int ge, bool aa) : base(ps, sn, ge)
        {
            Allradantrieb = aa;
        }

        public bool getAllradantrieb()
        {
            return Allradantrieb;
        }
    }
}
