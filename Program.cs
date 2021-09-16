using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de medidas");

            Console.WriteLine();

            Console.Write("Digite a medida desejada(em metros): ");
            string valorDigitado = Console.ReadLine();
            int metros = Int32.Parse(valorDigitado);

            Console.WriteLine();

            Console.WriteLine("--- Equivalência ---");
            Console.WriteLine("Medida em centimetros: " + metros*100 + " cm");
            Console.WriteLine("Medida em metros: " + metros + " m");
            Console.WriteLine("Medida em quilometros: " + metros*0.001 + " km");
            
        }
    }
}
