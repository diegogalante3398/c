using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    class Cliente
    {
		private string _nome;
		private string _rg;
		private string cpf;
		private string _endereco;

		public string Endereco
		{
			get { return _endereco; }
			set { _endereco = value; }
		}


		public string CPF
		{
			get { return cpf; }
			set { cpf = value; }
		}

		public string RG
		{
			get { return _rg; }
			set { _rg = value; }
		}

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

	}
}
