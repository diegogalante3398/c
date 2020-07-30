using System;
using System.Collections.Generic;
using System.Text;

namespace Lampada
{
    class Conta
    {
		private string _nome;
		private string _numConta;
		private double _saldo;

		public double Saldo
		{
			set { _saldo = value; }
		}

		public string NumConta
		{
			set { _numConta = value; }
		}

		public string Nome
		{
			set { _nome = value; }
		}

		public void Depositar(double deposito)
		{
			Saldo = deposito + ObterSaldo();
		}

		public void Saque(double saque)
		{
			Saldo = ObterSaldo() - saque;
		}

		public double ObterSaldo()
		{
			return _saldo;
		}

		public string ObterNumero()
		{
			return _numConta;
		}

		public string ObterNomeCliente()
		{
			return _nome;
		}
	}
}
