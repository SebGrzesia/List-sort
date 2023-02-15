using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list integer number separated by spacebar");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers));

            Console.ReadKey();
        }
    }
}
