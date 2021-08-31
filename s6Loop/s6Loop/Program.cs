using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s6Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            while(x<=8)
            {
                Console.WriteLine("We have the value x = " + x);
                x += 1;
                // += is the same thing as ++
            }

            Console.WriteLine("Loop for: \n");

            //for

            for (int i = 0;i<=10;i++)
            {
                Console.WriteLine("This is the loop for. The current i value is: " + i);
            }
            Console.ReadLine();
        }
    }
}
