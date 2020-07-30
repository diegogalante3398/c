using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuestao01
{
    public class Pessoa
    {
		private string nome;
		private DateTime nascimento;
		private double altura;

		public double Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		public DateTime Nascimento
		{
			get { return nascimento; }
			set { nascimento = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public int CalcularIdade()
		{
			int idade = DateTime.Now.Year - Nascimento.Year;
			
			if (DateTime.Now.Month < Nascimento.Month || DateTime.Now.Month == Nascimento.Month && DateTime.Now.Day < Nascimento.Day)
			{
				idade--;
			}

			return idade;
		}

	}
}
