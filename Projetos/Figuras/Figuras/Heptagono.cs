using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Heptagono: Figura
    {
        private double lado;
        private double apotema;

        public double Apotema
        {
            get { return apotema; }
            set { apotema = value; }
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return (7 * Lado * Apotema) / 2;
        }
        public override double CalcularPerimetro()
        {
            return 7 * Lado;
        }
    }
}
