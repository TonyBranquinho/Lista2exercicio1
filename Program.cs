using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());

            string saida = "nulo"; 
            if (numero >= 0) {
                saida = "nao é negativo";        
            }
            else {
                saida = "negativo";
            }

            Console.WriteLine(saida);
            Console.WriteLine();
        }
    }
}