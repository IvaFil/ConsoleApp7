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

            if (number % 7 == 1|| number %7 == 2|| number % 7 == 3|| number % 7 == 4|| number % 7 == 5)
            {
                Console.WriteLine("Нет");
            }
            else
            {
                Console.WriteLine("Да");
            }
           
        }
    }
}
