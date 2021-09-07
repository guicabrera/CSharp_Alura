using System;
using myBank;
//here we can see how to use the namespace feature to define an specific scope to the project

public class bankAccount
{
    //its possible gives a var a value to be started
    public customers customer = new customers();
    private int baNumber;
    private int baAgency;
    private double baLimit = 1000;
    //here when you create a new bankAccount the account will have 500$
    private double baBalance = 500;


    public int BaNumber { get; set; }
    public int BaAgency { get; set; }



    //declaring function in C#
    public bool withdraw(double valueWithdraw)
    {
        if ((this.baLimit + this.baBalance) < valueWithdraw)
        {
            Console.WriteLine("Insuficient Balance and limit to procede with this operation, please check your limit and try again");
            return false;
        }
        //when we are using a non void function we dont need put an else in the end of the if because the return ends the function
        this.baBalance -= valueWithdraw;
        Console.WriteLine("Operation done successfully");
        return true;
    }

    public void deposit(double valueDeposit)
    {
        this.baBalance += valueDeposit;
    }

    public bool transfer(double valueTransfer, bankAccount newAcc)
    {
        if (!this.withdraw(valueTransfer))
        {
            return false;
        }

        newAcc.baBalance += valueTransfer;
        return true;
    }

    public double extrato()
    {
        return this.baBalance;
    }
}

