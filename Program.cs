using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(50);
            //you can also use normal operators straight into the brackets
            Console.WriteLine(6 + 4);
            //you can write the numbers in qoutes to see them on console without calculation
            Console.WriteLine("6+4");
            Console.WriteLine(6 - 4);
            Console.WriteLine(6 *  4);
            Console.WriteLine(6 / 4.0);
            Console.WriteLine(6  % 4);
            Console.WriteLine(" 6 devided by 4 is " + 6/4 + " remainder " + 6%4);



            int num3 = 3;
            num3 = num3 + 1;
            num3 += 2;


            int num1 = 2;
            num1 = num1 + 1;
            Console.WriteLine("Num1 = " + num1);
            //shorter way of doing it
            int num2 = 2;
            num2++;
            Console.WriteLine("Num2 = ");

            Console.WriteLine(Math.Abs(num2));
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Min(5, 40));
            Console.WriteLine(Math.Pow(2,2));

                

            //freeze console
            Console.ReadLine();
        }
    }
}
