using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSlide1
{
    class CalcularArea
    {
		private int altura;
		private int largura;

		public int Largura
		{
			get { return largura; }
			set { largura = value; }
		}

		public int Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		public int CalcArea()
		{
			return Altura * Largura;
		}

	}
}
