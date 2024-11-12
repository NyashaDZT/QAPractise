using System;
using System.Dynamic;
using System.Security.Cryptography;
using LabExercise3;
using WeightConverter;
using Lab05;
using Lab06;
using Lab07;
using Lab08;
using LabEleven;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            // TheLunchQueue();
            // doWeights();
            // GetGrades();
            // ArrayMethods();
            // BankApp();

            // Account myAccount = new Account(2, "Mine", 100);
            // ProcessAccount(myAccount);

            // int k = 100;
            // IncInt(k);
            // Console.WriteLine(k);

            QAShop get = new QAShop();

            ShoppingBasket basket1 = new ShoppingBasket("Laptop", 1, 999.99);
            ShoppingBasket basket2 = new ShoppingBasket("Headphones", 2, 49.99);
            ShoppingBasket basket3 = new ShoppingBasket("Smartphone", 1, 599.99);

            get.Buy(basket1);
            get.Buy(basket2);
            get.Buy(basket3);


        }

        public static void TheLunchQueue()
        {
            Lab3Exercises get = new Lab3Exercises();

            string mainCourse = get.GetString("What main dish would you like(Fish, Burgers or veg) ?");
            int potatoes = get.GetInt("How many roast potatoes would you like? ");
            int brussels = get.GetInt("How many brussel sprouts would you like? ");

            string order = $"Hello your lunch is {mainCourse}, with {potatoes} roast potatoes and {brussels} Brussel sprouts.";

            Console.WriteLine(order);

            return;

        }

        public static void doWeights()
        {
            WeightCalculator calculator = new WeightCalculator();
            Lab3Exercises get = new Lab3Exercises();
            int pounds = get.GetInt("Pounds to Stones conversion, enter weight: ");
            calculator.ConvertInputToStonesPounds(pounds);
            int kgs = get.GetInt("Enter KGs to convert to pounds: ");
            calculator.ConvertKgsToStonesPounds(kgs);
        }

        public static void GetGrades()
        {
            Lab3Exercises get = new Lab3Exercises();
            Lab5 lab5 = new Lab5();
            int score = get.GetInt("What did you score? ");
            lab5.Grades(score);
            string summer = get.GetString("Is is summer, please answer with \'yes\' or \'no\'");
            string evening = get.GetString("Is it early evening, please answer with \'yes\' or \'no\'");
            lab5.Part2(summer, evening);

        }

        public static void CalculateGrades()
        {
            Loops grades = new Loops();

        }

        public static void ArrayMethods()
        {
            Lab7 get = new Lab7();
            Console.WriteLine(get.GetSum([1, 4, -5, 7, 0, 4, 6, 8]));
        }

        public static void BankApp()
        {

            // Account account = new Account(1, "Alice", 1000.0);

            // account.GetDetails();

            // account.Deposit(200.0);

            // account.Deposit(-50.0);

            // account.Withdraw(300.0);

            // account.Withdraw(2000.0);

            // account.GetDetails();

            Account myAccount = new Account(2, "Mine", 100);

            myAccount.AddInterest();

            myAccount.GetDetails();

            Account partnerAccount = myAccount;

            partnerAccount.AddInterest();

            myAccount.GetDetails();
        }

        static void ProcessAccount(Account acc)
        {
            acc.AddInterest();
        }

        private static void IncInt(int x)
        {

            x++;

        }
    }
}