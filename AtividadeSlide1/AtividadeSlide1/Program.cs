using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSlide1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carro carro1 = new Carro();
            Console.WriteLine("---------------CARRO 1---------------");
            carro1.Marca = "Volkswagen";
            carro1.Modelo = "atlas";
            carro1.Combustivel = "flex";
            carro1.Portas = 4;
            carro1.CapCombustivel = 45;

            Console.WriteLine("MARCA: " + carro1.Marca +
                              "\nMODELO: " + carro1.Modelo +
                              "\nCOMBUSTIVEL: " + carro1.Combustivel +
                              "\nPORTAS: " + carro1.Portas +
                              "\nCAPACIDADE DO TANQUE: " + carro1.CapCombustivel);

            Carro carro2 = new Carro();
            Console.WriteLine("---------------CARRO 2---------------");
            carro2.Marca = "Peugeot";
            carro2.Modelo = "peugeot 208";
            carro2.Combustivel = "flex";
            carro2.Portas = 4;
            carro2.CapCombustivel = 30;

            Console.WriteLine("MARCA: " + carro2.Marca +
                              "\nMODELO: " + carro2.Modelo +
                              "\nCOMBUSTIVEL: " + carro2.Combustivel +
                              "\nPORTAS: " + carro2.Portas +
                              "\nCAPACIDADE DO TANQUE: " + carro2.CapCombustivel);

            Carro carro3 = new Carro();
            Console.WriteLine("---------------CARRO 3---------------");
            carro3.Marca = "Hyundai ";
            carro3.Modelo = "Tucson";
            carro3.Combustivel = "flex";
            carro3.Portas = 4;
            carro3.CapCombustivel = 40;

            Console.WriteLine("MARCA: " + carro3.Marca +
                              "\nMODELO: " + carro3.Modelo +
                              "\nCOMBUSTIVEL: " + carro3.Combustivel +
                              "\nPORTAS: " + carro3.Portas +
                              "\nCAPACIDADE DO TANQUE: " + carro3.CapCombustivel);

            Carro carro4 = new Carro();
            Console.WriteLine("---------------CARRO 4---------------");
            carro4.Marca = "Hyundai";
            carro4.Modelo = "Creta";
            carro4.Combustivel = "flex";
            carro4.Portas = 4;
            carro4.CapCombustivel = 40;

            Console.WriteLine("MARCA: " + carro4.Marca +
                              "\nMODELO: " + carro4.Modelo +
                              "\nCOMBUSTIVEL: " + carro4.Combustivel +
                              "\nPORTAS: " + carro4.Portas +
                              "\nCAPACIDADE DO TANQUE: " + carro4.CapCombustivel);


            Carro carro5 = new Carro();
            Console.WriteLine("---------------CARRO 5---------------");
            carro5.Marca = "Honda";
            carro5.Modelo = "Civic";
            carro5.Combustivel = "flex";
            carro5.Portas = 4;
            carro5.CapCombustivel = 45;

            Console.WriteLine("MARCA: " + carro5.Marca +
                              "\nMODELO: " + carro5.Modelo +
                              "\nCOMBUSTIVEL: " + carro5.Combustivel +
                              "\nPORTAS: " + carro5.Portas +
                              "\nCAPACIDADE DO TANQUE: " + carro5.CapCombustivel);


            Console.WriteLine("---------------MATEMÁTICA---------------");
            Matematica matematica = new Matematica();
            Console.WriteLine("VALORES: 12 & 5\n" +
                              "\nSomar: " + matematica.Somar(12, 5) +
                              "\nSubtrair: " + matematica.Subtrair(12, 5) +
                              "\nMultiplicar: " + matematica.Multiplicar(12, 5) +
                              "\nDividir: " + matematica.Dividir(12, 5));


            Console.WriteLine("---------------CALCULAR ÁREA---------------");
            CalcularArea calcularArea = new CalcularArea();

            calcularArea.Altura = 5;
            calcularArea.Largura = 3;
            Console.WriteLine("Área: " + calcularArea.CalcArea());


            Console.WriteLine("---------------ALUNO---------------");
            Aluno aluno = new Aluno();
            aluno.NomeAluno = "Diego";
            aluno.NotaExercicio = 5;
            aluno.NotaProva = 8;
            aluno.NotaTrabalho = 7;
            
            Console.WriteLine("Aluno: " + aluno.NomeAluno +
                              "\nNota Exercício: " + aluno.NotaExercicio +
                              "\nNota Prova: " + aluno.NotaProva +
                              "\nNota Trabalho: " + aluno.NotaTrabalho);

            aluno.CalcMedia(0.1, 0.2, 0.6);

            Console.ReadLine();

        }
    }
}
