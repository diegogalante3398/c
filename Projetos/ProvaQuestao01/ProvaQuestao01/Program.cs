using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuestao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Minha Idade--------------");
            Pessoa pessoa01 = new Pessoa();

            pessoa01.Nome = "Diego";
            pessoa01.Altura = 1.80;

            DateTime nasc = new DateTime(1998, 03, 03);
            pessoa01.Nascimento= nasc;

            Console.WriteLine("nome: " + pessoa01.Nome +
                              "\naltura: " + pessoa01.Altura +
                              "\nnascimento: " + pessoa01.Nascimento +
                              "\nidade: " + pessoa01.CalcularIdade());

            Console.ReadLine();
        }
    }
}
