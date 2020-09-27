using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInserido;
            const double n1 = 9;
            const double n2 = 5;
            const double n3 = 32;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Converta °C em °F");
            Console.ResetColor();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Digite o valor desejado: ");

            Console.Write("Grau Celsius: ");
            valorInserido = Convert.ToDouble(Console.ReadLine());
            double resultado = valorInserido * n1 / n2 + n3;
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{valorInserido} °C equivalem a {resultado} °F");
            Console.ResetColor();
        }
    }
}
