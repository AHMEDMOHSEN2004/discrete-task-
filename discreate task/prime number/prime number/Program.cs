using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Please Enter Frist Number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Other Number:");
            int num1 = int.Parse(Console.ReadLine());

            if (num < 2)
                num = 2;

            Console.WriteLine("The prime number is :");
            for (int x = num; x <= num1; x++)
            {
                for (int h = 2; h <= num1; h++)
                {
                    if (x != h && x % h == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    Console.WriteLine("\t" + x);
                }
                flag = true;


            }
        }
    }
}
