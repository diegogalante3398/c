using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuestao02
{
    public class Elevador
    {

		private int andarAtual = 0;
		private int andares;
		private int capacElevador;
		private int qtdPessoas = 0;

		public int QtdPessoas
		{
			get { return qtdPessoas; }
			set { qtdPessoas = value; }
		}

		public int CapacElevador { get { return capacElevador; } }

		public int Andares { get { return andares; } }

		public int AndarAtual
		{
			get { return andarAtual; }
			set { andarAtual = value; }
		}

		public void inicializar(int capacElevador, int andares)
		{
			this.capacElevador = capacElevador;
			this.andares = andares;
		}

		public void entra()
		{
			if(QtdPessoas < CapacElevador)
			{
				QtdPessoas++;
			}
			else
			{
				Console.WriteLine("Elevador cheio");
			}
		}

		public void sai()
		{
			if (QtdPessoas > 0)
			{
				QtdPessoas--;
			}
			else
			{
				Console.WriteLine("Elevador vazio");
			}
		}

		public void sobe()
		{

			if(AndarAtual < Andares)
			{
				andarAtual++;
			}
			else
			{
				Console.WriteLine("Último andar");
			}
		}
		public void desce()
		{

			if (AndarAtual <= Andares && andarAtual > 0)
			{
				andarAtual--;
			}
			else
			{
				Console.WriteLine("Térreo");
			}
		}

	}
}
