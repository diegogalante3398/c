using System;

namespace Lampada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------LAMPADA----------");
            Lampada l1 = new Lampada();

            l1.Ligada();
            Console.WriteLine("Acessa: " + l1.Acesa);
            Console.WriteLine("Queimada: " + l1.Queimada);

            l1.Desligada();
            Console.WriteLine(l1.Acesa);

            
            Console.WriteLine("----------LAMPADA 2----------");
            AbstLampada l2 = new AbstLampada();

            l2.Ligada();
            Console.WriteLine(l2.Acesa);
            l2.Desligada();
            Console.WriteLine(l2.Acesa);

            l2.Voltagem = 220;
            Console.WriteLine("Voltagem: " + l2.Voltagem);
            l2.Potencia = 60;
            Console.WriteLine("Potencia: " + l2.Potencia);

            Console.WriteLine("----------CONTA 1----------");
            Conta cliente1 = new Conta();

            cliente1.Nome = "Diego Galante";
            cliente1.NumConta = "12345";
            cliente1.Saldo = 1000;

            cliente1.Depositar(500);
            cliente1.Saque(200);

            Console.WriteLine("Nome: " + cliente1.ObterNomeCliente());
            Console.WriteLine("Numero da Conta: " + cliente1.ObterNumero());
            Console.WriteLine("Saldo: " + cliente1.ObterSaldo());

            Console.WriteLine("----------CONTA 2----------");
            Conta cliente2 = new Conta();

            cliente2.Nome = "Aline Stefane";
            cliente2.NumConta = "54321";
            cliente2.Saldo = 800;

            cliente2.Depositar(200);
            cliente2.Saque(300);

            Console.WriteLine("Nome: " + cliente2.ObterNomeCliente());
            Console.WriteLine("Numero da Conta: " + cliente2.ObterNumero());
            Console.WriteLine("Saldo: " + cliente2.ObterSaldo());

            Console.WriteLine("----------CONTA 3----------");
            Conta cliente3 = new Conta();

            cliente3.Nome = "Carlos Silva";
            cliente3.NumConta = "55443";
            cliente3.Saldo = 300;

            cliente3.Depositar(100);
            cliente3.Saque(400);

            Console.WriteLine("Nome: " + cliente3.ObterNomeCliente());
            Console.WriteLine("Numero da Conta: " + cliente3.ObterNumero());
            Console.WriteLine("Saldo: " + cliente3.ObterSaldo());
        }
    }
}
