using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Estrutura de classe --> object has been created on other file (contaCorrente.cs)
            bankAccount acc1 = new bankAccount();
            bankAccount acc2 = new bankAccount();

            //values to properties on class
            acc1.baAgency = 155;
            acc1.baName = "Guilherme Provencio";
            acc1.baNumber = 59667;

            //values to properties on class
            acc2.baAgency = 130;
            acc2.baName = "José Frovencio";
            acc2.baNumber = 58557;

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Agency: " + acc1.baAgency);
            Console.WriteLine("Number: " + acc1.baNumber);
            //acc1.withdraw(500);
            Console.WriteLine("Balance: " + acc1.extrato());
            Console.WriteLine("Name: " + acc1.baName);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Transfer");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            acc1.transfer(250, acc2);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            //when we are using objects, we have the difference of object values (when compared objects to objects) because each object has a reference number
            Console.ReadLine();
        }
    }
}
