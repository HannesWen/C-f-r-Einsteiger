using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_für_Einsteiger
{
    class Auto
    {
        private int ps;
        private int startnummer;
        private int geschwindigkeit;

        public Auto(int ps, int sn, int ge)
        {
            this.ps = ps;
            this.startnummer = sn;
            this.geschwindigkeit = ge;
        }

        public int getPs()
        {
            return this.ps;
        }
        public int getStartnummer()
        {
            return this.startnummer;
        }
        public int getGeschwindigkeit()
        {
            return this.geschwindigkeit;
        }
        public void setGeschwindigkeit(int wert)
        {
            this.geschwindigkeit = wert;
        }
    }

}
