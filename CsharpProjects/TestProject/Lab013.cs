using System.Data.Common;

namespace Lab13
{
    public class AccountException
    {
        private int id;
        private double balance;
        private string owner;

        public AccountException(int accountId, double initialBalance, string accountOwner)
        {
            id = accountId;
            balance = initialBalance;
            owner = accountOwner;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
            }

        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentException();
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}");

            }
        }

        // public int ID

        // {

        //     get { return id; }

        //     set { id = value; }

        // }

        // public string Owner
        // {
        //     get { return owner; }

        //     set { owner = value; }
        // }

        public void GetDetails()
        {
            Console.WriteLine($"Account ID: {id}");
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine($"Balance: {balance:C}");
        }

        public void close()
        {
            Console.WriteLine($"Account{id} is closed!");
        }


    }
}