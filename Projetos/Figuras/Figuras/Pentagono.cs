using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Pentagono: Figura
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
            return (Lado* 5 * Apotema) / 2;
        }
        public override double CalcularPerimetro()
        {
            return Lado*5;
        }
    }
}
