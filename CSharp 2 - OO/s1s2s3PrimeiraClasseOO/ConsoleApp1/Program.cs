using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Estrutura de classe --> object has been created on other file (contaCorrente.cs)
            bankAccount acc1 = new bankAccount();
            
            //values to properties on class
            acc1.baAgency = 155;
            acc1.baBalance = 5000;
            acc1.baName = "Guilherme Provencio";
            acc1.baNumber = 59667;


            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Agency: " + acc1.baAgency);
            Console.WriteLine("Number: " + acc1.baNumber);
            acc1.withdraw(500);
            Console.WriteLine("Balance: " + acc1.baBalance);
            Console.WriteLine("Name: " + acc1.baName);
            Console.WriteLine("-------------------------------------------------------------------------");

            //when we are using objects, we have the difference of object values (when compared objects to objects) because each object has a reference number
            Console.ReadLine();
        }
    }
}
