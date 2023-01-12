using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace PiramidaOtChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            var n = int.Parse(Console.ReadLine());


            int temp = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write($"{temp++} ");
                    if (temp == (n+1))
                        break;
                }
                if (temp == (n+1))
                    break;
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
