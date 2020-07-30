using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Hexagono: Figura
    {
		private double lado;

		public double Lado
		{
			get { return lado; }
			set { lado = value; }
		}

		public override double CalcularArea()
		{
			return (3 * Math.Pow(Lado, 2) * Math.Sqrt(3)) / 2;
		}
		public override double CalcularPerimetro()
		{
			return 6*Lado;
		}
	}
}
