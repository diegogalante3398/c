using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public abstract class Figura
    {
        public virtual double CalcularArea()
        {
            throw new Exception("Cálculo de área não implementado");
        }

        public virtual double CalcularPerimetro()
        {
            throw new Exception("Cálculo de perímetro não implementado");
        }
    }
}