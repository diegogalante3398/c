using System;
using System.Collections.Generic;
using System.Text;

namespace Lampada
{
	public class Lampada
	{
		private bool _acesa;
		private bool _queimada;

		public bool Queimada
		{
			get { return _queimada; }
			set { _queimada = LampadaQueimada(); }
		}

		public bool Acesa
		{
			get { return _acesa; }
		}

		public bool LampadaQueimada()
		{
			Random n = new Random();
			n.Next(100);

			if (n.Next(100) <= 85)
			{
				//Lampada não queimada
				return false;
			}
			else
			{
				//Lampada queimada
				return true;
			}
		}

		public void Ligada()
		{
			if (LampadaQueimada())
			{
				//apagada
				_acesa = false;
			}
			else
			{
				//acesa
				_acesa = true;
			}
		}

		public void Desligada()
		{
			_acesa = false;
		}
	}
}