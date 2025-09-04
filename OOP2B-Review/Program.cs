using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP2B_Review
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            //int c = AddNums(a, b);
            //Console.WriteLine(AddNums(c, int.Parse(Console.ReadLine())));

            MultNum(5, 4);
            DivNum(4, 9);

            Console.ReadKey();
        }

        static int AddNums(int x, int y)
        {
            //Console.WriteLine($"The sum of {x} and {y} is {x + y}");
            return x + y;
        }

        static int SubNums(int x, int y)
        {
            return x - y;
        }

        static void MultNum(int x, int y)
        {
            int prod = 0;
            for(int i = 0; i < y;  i++)
            {
                prod = AddNums(prod, x);
            }

            Console.WriteLine($"{x} * {y} = {prod}");
        }

        static void DivNum(int x, int y)
        {
            int quo = 0;

            while(x > y)
            {
                x = SubNums(x, y);
            }

            Console.WriteLine($"{x} / {y} = {quo} r {x}");
        }
    }
}
