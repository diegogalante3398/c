using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSlide1
{
    class Carro
    {
		private string _marca;
		private string _modelo;
		private string _combustivel;
		private int _portas;
		private double _cap_combustivel;

		public double CapCombustivel
		{
			get { return _cap_combustivel; }
			set { _cap_combustivel = value; }
		}


		public int Portas
		{
			get { return _portas; }
			set { _portas = value; }
		}


		public string Combustivel
		{
			get { return _combustivel; }
			set { _combustivel = value; }
		}


		public string Modelo
		{
			get { return _modelo; }
			set { _modelo = value; }
		}


		public string Marca
		{
			get { return _marca; }
			set { _marca = value; }
		}

	}
}
