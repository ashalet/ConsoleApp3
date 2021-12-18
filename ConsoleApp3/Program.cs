using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rr = new Random();
            int[] array = new int[10];
            array[0] = 7;
            for (int j = 1; j < array.Length; j++)
            {
                array[j] = rr.Next(0, 100);
            }

            int result = prog(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int prog(int[] array)
        {
            int maxim = -1;
            for (int i = 1; i < array.Length; i+=2)
            {
                if (array[i] % 7 == 0)
                {
                    if (array[i] > maxim)
                    {
                        maxim = array[i];
                    }
                }
            }

            return maxim;
        }
    }
}
