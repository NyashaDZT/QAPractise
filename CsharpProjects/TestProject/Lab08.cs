namespace Lab08
{
    public class Account
    {
        private int id;
        private string owner;
        private double balance;

        public Account(int accountId, string accountOwner, double initialBalance)
        {
            id = accountId;
            owner = accountOwner;
            balance = initialBalance;
        }


        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit unacceptable, below the deposit amount.");
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
                Console.WriteLine("Unable to withdraw, please add funds to your account");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}");

            }
        }

        public int ID

        {

            get { return id; }

            set { id = value; }

        }

        public string Owner
        {
            get { return owner; }

            set { owner = value; }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Account ID: {ID}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Balance: {balance:C}");
        }

        public void AddInterest()
        {
            if (balance > 0)
            {
                double interestRate = 0.025; // 2.5% interest
                double interest = balance * interestRate;
                balance += interest;
                Console.WriteLine($"Interest added: {interest:C}. New balance: {balance:C}");
            }
        }
    }
}
