using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuestao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Elevador----------------");
            Elevador elevador = new Elevador();

            elevador.inicializar(20, 10);// capacidade = 20; qtd andares = 10
            Console.WriteLine("Andar atual: " + elevador.AndarAtual +
                              "\nQuantidade de andares: " + elevador.Andares +
                              "\nCapacidade de pessoas: " + elevador.CapacElevador +
                              "\nQuantidade de Pessoas : " + elevador.QtdPessoas +
                              "\n------------------------------------");

             // adiciona 20 pessoa e avisa que está lotado
            for (int cont = 0; cont <= 20; cont++){ elevador.entra(); }
            Console.WriteLine("ENTRA" +
                                "\nAndar atual: " + elevador.AndarAtual +
                                "\nQuantidade de Pessoas : " + elevador.QtdPessoas +
                                "\n------------------------------------");

            // sobe 10 andares e avisa que chegou no ultimo andar
            for (int cont = 0; cont <= 10; cont++) { elevador.sobe(); }
            Console.WriteLine("SOBE" +
                                "\nAndar atual: " + elevador.AndarAtual +
                                "\nQuantidade de Pessoas : " + elevador.QtdPessoas +
                                "\n------------------------------------");

            // retira 10 pessoa
            for (int cont = 0; cont <= 9; cont++) { elevador.sai(); }
            Console.WriteLine("SAI" +
                                "\nAndar atual: " + elevador.AndarAtual +
                                "\nQuantidade de Pessoas : " + elevador.QtdPessoas +
                                "\n------------------------------------");

            // desce 5 andares
            for (int cont = 0; cont <= 4; cont++) { elevador.desce(); }
            Console.WriteLine("DESCE" +
                              "\nAndar atual: " + elevador.AndarAtual +
                              "\nQuantidade de Pessoas : " + elevador.QtdPessoas +
                              "\n------------------------------------");

            // Desce até o térreo, gera a msg de erro de térreo 
            for (int cont = 0; cont <= 5; cont++) { elevador.desce(); }

            // Retira as pessoas e gera a mensagem de erro de elevador vazio
            for (int cont2 = 0; cont2 <= 10; cont2++) { elevador.sai(); }
            Console.WriteLine("DESCE" +
                              "\nAndar atual: " + elevador.AndarAtual +
                              "\nQuantidade de Pessoas : " + elevador.QtdPessoas +
                              "\n------------------------------------");

            Console.ReadLine();
        }
    }
}
