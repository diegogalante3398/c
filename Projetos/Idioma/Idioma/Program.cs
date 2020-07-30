using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idioma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a linguagem? ");
            var lingua = Console.ReadLine();

            CumprimentadorFactory cf = new CumprimentadorFactory("Montanha");

            Cumprimentador c = cf.NewCumprimentador(lingua);

            Console.WriteLine(c.Dizer());

            Console.ReadLine();
        }
    }
}
