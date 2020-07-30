using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("--------------Quadrado--------------");
            Quadrado quadrado = new Quadrado();

            Console.Write("Lado do quadrado: ");
            string b = Console.ReadLine();
            quadrado.B = double.Parse(b);

            Console.WriteLine("Área: " + quadrado.CalcularArea() +
                              "\nPerímetro: " + quadrado.CalcularPerimetro());

            Console.WriteLine("--------------Circulo--------------");
            Circulo circulo = new Circulo();

            Console.Write("Raio: ");
            string r = Console.ReadLine();
            circulo.R = double.Parse(r);

            Console.WriteLine("Área: " + circulo.CalcularArea() +
                              "\nPerímetro: " + circulo.CalcularPerimetro());

            Console.WriteLine("--------------Pentágono--------------");
            Pentagono pentagono = new Pentagono();

            Console.Write("lado: ");
            string l1 = Console.ReadLine();
            Console.Write("apotema: ");
            string ap1 = Console.ReadLine();


            pentagono.Lado = double.Parse(l1);
            pentagono.Apotema = double.Parse(ap1);

            Console.WriteLine("Área: " + pentagono.CalcularArea() +
                              "\nPerímetro: " + pentagono.CalcularPerimetro());

            Console.WriteLine("--------------Hexágono--------------");
            Hexagono hexagono = new Hexagono();

            Console.Write("lado: ");
            string l2 = Console.ReadLine();

            hexagono.Lado = double.Parse(l2);
           
            Console.WriteLine("Área: " + hexagono.CalcularArea() +
                              "\nPerímetro: " + hexagono.CalcularPerimetro());
            
            Console.WriteLine("--------------Heptágono--------------");
            Heptagono heptagono = new Heptagono();

            Console.Write("lado: ");
            string l3 = Console.ReadLine();
            Console.Write("apotema: ");
            string ap3 = Console.ReadLine();

            heptagono.Lado = double.Parse(l3);
            heptagono.Apotema = double.Parse(ap3);

            Console.WriteLine("Área: " + heptagono.CalcularArea() +
                              "\nPerímetro: " + heptagono.CalcularPerimetro());
            
            Console.WriteLine("--------------Octogono--------------");
            Octogono octogono = new Octogono();

            Console.Write("lado: ");
            string l4 = Console.ReadLine();
            Console.Write("apotema: ");
            string ap4 = Console.ReadLine();

            octogono.Lado = double.Parse(l4);
            octogono.Apotema = double.Parse(ap4);

            Console.WriteLine("Área: " + octogono.CalcularArea() +
                              "\nPerímetro: " + octogono.CalcularPerimetro());

            Console.ReadKey();
        }
    }
}
