namespace Lab04
{
    class IfElse
    {
        public void Part1()
        {
            Console.WriteLine("Price of a bag please? ");
            string price = Console.ReadLine();
            Console.WriteLine("How much money do you have? ");
            string money = Console.ReadLine();

            double num;
            double amount;


            bool isNum = double.TryParse(price, out num);
            bool isMoney = double.TryParse(money, out amount);


            if (isNum && isMoney)
            {
                if (num <= 0)
                {
                    Console.WriteLine("Price must be greater than zero.");
                }
                
                else if (amount < num)
                {
                    Console.WriteLine("Money must be greater than or equal to price.");
                }
                
                else if (amount == 0)
                {
                    Console.WriteLine("Come back with your pocket money.");
                }
                
                else
                {
                    int bags = (int)(amount / num);
                    Console.WriteLine($"You can afford {bags} bags.");
                }
            }
        }

    }

}