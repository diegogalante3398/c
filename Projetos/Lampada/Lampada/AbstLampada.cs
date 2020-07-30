using System;
using System.Collections.Generic;
using System.Text;

namespace Lampada
{
	public class AbstLampada : Lampada
	{
		private int _potencia;
		private int _voltagem;

		public int Voltagem
		{
			get { return _voltagem; }
			set { _voltagem = value; }
		}

		public int Potencia
		{
			get { return _potencia; }
			set { _potencia = value; }
		}

	}
}