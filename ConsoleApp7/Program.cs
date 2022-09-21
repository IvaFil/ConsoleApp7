using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число: ");

            int number = Convert.ToInt32(Console.ReadLine());

            number /= 10;
            number %= 10;
            Console.WriteLine(number);

        }
    }
}
