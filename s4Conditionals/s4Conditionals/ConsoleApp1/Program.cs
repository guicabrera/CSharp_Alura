using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto de condicionais");


            //estrutura condicional if A1
            int idade = 15;
            string name = "João";

            if(idade>=18)
            {
                Console.WriteLine(name + " é maior de idade\nIdade: "+idade);
            } else
            {
                Console.WriteLine(name + " é menor de idade \nIdade:"+idade);
            }

            //Estruturas condicionais 2 A2 || --> e or ; && --> ou or
            if(idade>14 && name == "João")
            {
                Console.WriteLine("Have 15 Years and your name is João");
            }

            if(idade>14 && idade == 15)
            {
                Console.WriteLine("Have 15 Years old");
            }

            bool verification = idade < 16;
            if (verification)
            {
                Console.WriteLine("Verification is true");
            }

            //scope of var's


            Console.ReadLine();
        }
    }
}
