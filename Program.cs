using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02_For__Impressão_de_Números_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro N: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Números primos de 1 até {0}:", N);
            for (int i = 2; i <= N; i++)
            {
                bool primo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                    Console.Write($"{i} ");

                Console.ReadKey();  
            }
        }
    }
}
    
