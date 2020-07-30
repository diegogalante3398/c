using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Quadrado : Figura
    {
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public override double CalcularPerimetro()
        {
            return b * 4;
        }

        public override double CalcularArea()
        {
            return b * b;
        }
    }
}
