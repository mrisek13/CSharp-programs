using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_04
{
    class Kugla
    {
        float polumjer;

        public void SetPolumjer(float polumjer)
        {
            this.polumjer = polumjer;
        }

        public float GetPolumjer()
        {
            return polumjer;
        }

        public float Polumjer
        {
            get { return polumjer; }
            set { polumjer = value; }
        }

        private double IzracunajOplosje()
        {
            return Math.Round(4 * Math.Pow(polumjer, 2) * Math.PI, 2);
        }

        public double Volumen
        {
            get
            {
                return Math.Round(4 / 3 * Math.Pow(polumjer, 3) * Math.PI, 2);
            }
        }

        public override string ToString()
        {
            return $"Polumjer: {polumjer} Oplošje: {IzracunajOplosje()} Volumen: {Volumen}";
        }
    }
}
