using System;

namespace ProvaQuestao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------TELEVISÃO------------------------");
            ControleRemoto samsungControle = new ControleRemoto();
            Televisao samsungTV = new Televisao();

            samsungControle.Controle = samsungTV;

            //aumenta o volume da TV para 30 e coloca no canal 12
            samsungControle.Controle.alterarCanal(12);
            for(int cont=0; cont<20; cont++){ samsungControle.Controle.aumentarVolume(); }
            Console.WriteLine(samsungControle.Controle.consultar());
            Console.WriteLine("----------------------");

            //diminui o volume da TV para 20 e desce um canal
            samsungControle.Controle.descerCanal();
            for (int cont = 0; cont < 10; cont++){ samsungControle.Controle.diminuitVolume();}
            Console.WriteLine(samsungControle.Controle.consultar());
            Console.WriteLine("----------------------");

            //sobe 2 canais
            for (int cont = 0; cont < 2; cont++){ samsungControle.Controle.subirCanal(); }
            Console.WriteLine(samsungControle.Controle.consultar());
            Console.WriteLine("----------------------");

            Console.ReadLine();
        }
    }
}
