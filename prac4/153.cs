using System;

class BankAccount
{
    public double Balance { get; private set; }

    public void Deposit(double amount) => Balance += amount;

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient Balance");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        acc.Withdraw(300);

        Console.WriteLine("Balance: " + acc.Balance);
    }
}