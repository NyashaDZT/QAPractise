using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Lab012
{
    public class Vehicle
    {

        public static int count { get; private set; } = 0;
        private int speed;
        private int lane;

        public RegistrationPlate registrationPlate;

        public int DistanceTravelled { get; private set; }

        public Vehicle(int speed, int lane)
        {
            this.speed = speed;
            this.lane = lane;
            count++;
            registrationPlate = RegistrationPlateFactory.GetNextRegistrationPlate();
        }
        void accelerate(int amount)
        {

        }

        void brake(int amount)
        {
            speed -= amount;
        }

        string getDetails()
        {
            return "";
        }

    }

    public class RegistrationPlate
    {       
        public string RegPlate {get; private set;}

        public RegistrationPlate(string regPlate)
        {
            RegPlate = regPlate;
        }

    }

    class RegistrationPlateFactory
    {
        private static int count = 0;
        private static string[] regPlates = 
                { "MRB1G", "RU16", "TOY4US", "HNZ57", "PUT3", "JB007" };

        public static RegistrationPlate GetNextRegistrationPlate()
        {
            count++;
            if(count >= regPlates.Length)
            {
                throw new Exception($"No more registration plates!");
            }
            else
            {
                return new RegistrationPlate(regPlates[count]);
            }
        }
    }


}