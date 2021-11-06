using System;

namespace Exercicio_negativo_
{
    class Program
    {
        static void Main(string[] args)
        {
            //caso o usuario digite um numero menor que 0 apresentar a seguinte mensagem você digitou um numero negativo
            
            double numeronegativo;
            
            Console.Write("\nDigite um número: ");
            numeronegativo = Convert.ToDouble(Console.ReadLine());

            if(numeronegativo<0)
            {
                Console.WriteLine("O número que você digitou é negativo.");
            }
            Console.WriteLine("");
        }
    }
}
