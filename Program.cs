using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciFinder
{
    internal class Program
    {
        static ulong FibonacciFinder(int n)
        {
            int index = n - 1;
            n = n - 2;
            int counter = 1;
            var list = new List<ulong>() {0, 1};
            while (n > 0)
            {
                ulong previous = list[counter - 1];
                ulong current = list[counter];
                list.Add(previous + current);
                counter++;
                n--;
            }
            return list[index];
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}th number of Fibonacci is {FibonacciFinder(n)}");
        }
    }
}
