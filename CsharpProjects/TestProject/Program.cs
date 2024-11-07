using System;
using System.Dynamic;
using System.Security.Cryptography;
using LabExercise3;
using WeightConverter;
using Lab05;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            // TheLunchQueue();
            // doWeights();
            GetGrades();
            
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
    }
}