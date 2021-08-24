using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto de condicionais");


            //estrutura condicional if
            int idade = 15;
            string name = "João";

            if(idade>=18)
            {
                Console.WriteLine(name + " é maior de idade\nIdade: "+idade);
            } else
            {
                Console.WriteLine(name + " é menor de idade \nIdade:"+idade);
            }

            Console.ReadLine();
        }
    }
}
