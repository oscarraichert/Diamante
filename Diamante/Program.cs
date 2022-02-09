using System;

namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra_final = (char)Console.Read();
            int espaco = 0;
            int espaco2 = 0;

            for (char letra = 'a'; letra <= letra_final; letra++)
            {
                Console.Write($"{new string(' ', (letra_final - 'a') - espaco)}{letra}");
                if (letra != 'a')
                {
                    Console.Write($"{new string(' ', espaco + espaco - 1)}{letra}");
                }
                Console.WriteLine();
                espaco++;
            }

            espaco2 = espaco;
            espaco = 1;

            for (char letra = (char)(letra_final - 1); 'a' <= letra; letra--)
            {
                Console.Write($"{new string(' ', espaco)}{letra}");
                if (letra != 'a')
                {
                    Console.Write($"{new string(' ', espaco2 + espaco2 - 5)}{letra}");
                }
                Console.WriteLine();
                espaco2--;
                espaco++;
            }
        }
    }
}