using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Circulo : Figura
    {
        private double r;

        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override double CalcularPerimetro()
        {
            return (2 * Math.PI * r);
        }
    }
}
