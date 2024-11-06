using Lab01;

namespace WeightConverter 
{
    class WeightCalculator
    {
        public void ConvertInputToStonesPounds(int pounds)
        {
            decimal stones = pounds / 14;
            Console.WriteLine($"{pounds} pounds converted to Stones = {stones}");

            return;
        }

        public void ConvertKgsToStonesPounds(int kgs)
        {
            double pounds = kgs * 2.204;
            Console.WriteLine($"{kgs} KGS converted to Pounds = {pounds}");
        }
    }
}