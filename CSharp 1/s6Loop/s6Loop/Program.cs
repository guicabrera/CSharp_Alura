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

            for (int i = 0;i<=10;i+=2)
            {
                Console.WriteLine("This is the loop for. The current i value is: " + i);
            }


            //break + for encadeado
            string ast = "*";
            for (int i2 = 1; i2 < 10; i2++)
            {
                
                Console.WriteLine(ast);
                ast = ast + "*";
            }

            for(int i3 = 1; i3 <= 10; i3++)
            {
                for(int i4 = 1; i4 <= i3; i4++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i5 = 1; i5 <= 10; i5++)
            {
                for(int i6 = 1; i6 <= 10; i6++)
                {
                    Console.Write("*");
                    if(i5 == i6)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
