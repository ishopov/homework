using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            if (num1 < 1000)
            {
                if (num1 < 100)
                {
                    if (num1 < 10)
                    {
                        Console.Write($"000{num1} ");
                    }
                    else Console.Write($"00{num1} ");
                }
                else Console.Write($"0{num1} ");
            }
            else Console.Write($"{num1} ");

            if (num2 < 1000)
            {
                if (num2 < 100)
                {
                    if (num2 < 10)
                    {
                        Console.Write($"000{num2} ");
                    }
                    else Console.Write($"00{num2} ");
                }
                else Console.Write($"0{num2} ");
            }
            else Console.Write($"{num2} ");

            if (num3 < 1000)
            {
                if (num3 < 100)
                {
                    if (num3 < 10)
                    {
                        Console.Write($"000{num3} ");
                    }
                    else Console.Write($"00{num3} ");
                }
                else Console.Write($"0{num3} ");
            }
            else Console.Write($"{num3} ");

            if (num4 < 1000)
            {
                if (num4 < 100)
                {
                    if (num4 < 10)
                    {
                        Console.WriteLine($"000{num4} ");
                    }
                    else Console.WriteLine($"00{num4} ");
                }
                else Console.WriteLine($"0{num4} ");
            }
            else Console.WriteLine($"{num4} ");            
        }
    }
}
