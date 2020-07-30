using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSlide1
{
    class Aluno
    {
		private string nomeAluno;
		private double notaExercicio;
		private double notaTrabalho;
		private double notaProva;

		public double NotaProva
		{
			get { return notaProva; }
			set { notaProva = value; }
		}

		public double NotaTrabalho
		{
			get { return notaTrabalho; }
			set { notaTrabalho = value; }
		}

		public double NotaExercicio
		{
			get { return notaExercicio; }
			set { notaExercicio = value; }
		}

		public string NomeAluno
		{
			get { return nomeAluno; }
			set { nomeAluno = value; }
		}

		public void CalcMedia(double pe, double pt, double pp)
		{
			if (pe+pt+pp == 1)
			{
				Console.WriteLine("\nMédia: " + ( (NotaExercicio * pe) + (NotaTrabalho * pt) + (NotaProva * pp) / (pe + pt + pp)));
			}
			else
			{
				Console.WriteLine("A SOMA DOS PESOS DE PROVA, TRABALHO E EXERCÍCIOS DEVEM SER IGUAIS A 1!");
			}
		}

	}
}
