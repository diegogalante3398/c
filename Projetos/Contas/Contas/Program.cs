using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------------- 1.0 ----------------");
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            
            conta.Titular = cliente;

            conta.Titular.Nome = "Victor";
            conta.Titular.CPF = "14485129640";
            conta.Titular.RG = "19627348";
            conta.Titular.Endereco = "rua carmem silvia guimaraes 252";

            Console.WriteLine("NOME: " +  conta.Titular.Nome +
                              "\nCPF: " + conta.Titular.CPF +
                              "\nRG: " + conta.Titular.RG +
                              "\nENDERECO: " + conta.Titular.Endereco);
            
            Console.WriteLine("---------------- 2.0 ----------------");
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();

            guilherme.Nome = "Guilherme Siveira";
            umaConta.Titular = guilherme;

            Console.WriteLine(umaConta.Titular.Nome);
            
            Console.WriteLine("---------------- 3.0 ----------------");
            Conta umaConta2 = new Conta();
            Cliente guilherme2 = new Cliente();

            guilherme2.RG="12345678-9";

            umaConta2.Titular = guilherme2;
            umaConta2.Titular.RG = "98765432-1";

            Console.WriteLine(guilherme2.RG);
            Console.ReadLine();
        }
    }
}
