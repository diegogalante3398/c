using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Data
{
    class Program
    {
        static void Main(string[] args)
        {
            CovidPais cp = new CovidPais();
            Console.WriteLine("Digite o código de um país: ");
            string cod_pais = Console.ReadLine();

            Console.WriteLine("-------------------------Questão 1-------------------------");
            cp.ListraFiltrada(cod_pais);
            Console.ReadKey();

            Console.WriteLine("\n-------------------------Questão 2-------------------------");
            cp.PrimeiroDaLista(cod_pais);
            Console.ReadKey();

            Console.WriteLine("\n-------------------------Questão 3-------------------------");
            Console.WriteLine($"Velocidade de contaminação: {cp.VelocidadeContaminacao(cod_pais)}");
            Console.ReadKey();

            Console.WriteLine("\n-------------------------Questão 4-------------------------");
            Console.WriteLine($"Velocidade de Letalidade: {cp.VelocidadeLetalidade(cod_pais)}");
            Console.ReadKey();
        }
    }
}
