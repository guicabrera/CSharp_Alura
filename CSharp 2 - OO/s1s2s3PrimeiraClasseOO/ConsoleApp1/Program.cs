using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Estrutura de classe --> object has been created on other file (contaCorrente.cs)
            bankAccount acc1 = new bankAccount();
            bankAccount acc2 = new bankAccount();
            
            
            /*
           //values to properties on class
           acc1.baAgency = 155;

           acc1.baNumber = 59667;

           //values to properties on class
           acc2.baAgency = 130;

           acc2.baNumber = 58557;

           Console.WriteLine("---------------------------------------------------------------------------------------------------------");
           Console.WriteLine("Agency: " + acc1.baAgency);
           Console.WriteLine("Number: " + acc1.baNumber);
           //acc1.withdraw(500);
           Console.WriteLine("Balance: " + acc1.extrato());

           Console.WriteLine("---------------------------------------------------------------------------------------------------------");
           Console.WriteLine();
           Console.WriteLine("Transfer");
           Console.WriteLine("---------------------------------------------------------------------------------------------------------");
           acc1.transfer(250, acc2);
           Console.WriteLine("---------------------------------------------------------------------------------------------------------");
           //when we are using objects, we have the difference of object values (when compared objects to objects) because each object has a reference number
           */

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            customers jose = new customers();
            jose.CustomerName="jose";
            jose.CustomerAddess = "Rua Balalaika do São Juao";
            jose.CustomerBirthday = "24/08/2021";
            jose.CustomerDocument = "509.659.555-85";


            acc1.customer = jose;
            acc1.BaAgency = 155;
            acc1.BaNumber = 59667;

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
