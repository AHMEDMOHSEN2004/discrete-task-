using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace perfecte_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, r;
            Console.WriteLine("enter the frist number :");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number :");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the perfect number is :");
            for (int i = n1; i <= n2; i++)
            {
                int factor = 0;
                for (int z = 1; z <= n2; z++)
                {
                    if ((i % z == 0) & (i != 1))
                    {
                        if (z == i)
                        {
                            continue;

                        }
                        else
                            factor += z;
                    }
                    else
                        continue;

                }
                if (factor == i)
                {
                    Console.WriteLine(i);
                }
                else
                    factor = 0;
                
                   
}
           


        }
    }
}
    
