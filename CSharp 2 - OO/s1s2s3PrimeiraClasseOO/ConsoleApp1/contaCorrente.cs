using System;
public class bankAccount
{
    //its possible gives a var a value to be started
    public string baName;
    public int baNumber;
    public int baAgency;
    public double baLimit;
    //here when you create a new bankAccount the account will have 500$
    public double baBalance = 500;

    //declaring function in C#
    public void withdraw(double valueWithdraw)
    {
        if ((this.baLimit + this.baBalance) < valueWithdraw)
        {
            Console.WriteLine("Insuficient Balance and limit to procede with this operation, please check your limit and try again");
        } else
        {
            this.baBalance -= valueWithdraw;
            Console.WriteLine("Amount withdrawn successfully");
        }
    }
}