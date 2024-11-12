namespace ZooApp
{
    public class Zoo
    {
        // Default constructor
        public Zoo()
        {
            Console.WriteLine("A new Zoo has been created!");

            animalMap = new Dictionary<string, int>();
        }

        Dictionary<string, int> animalMap = null;
        string[] originalAnimals = ["Zebra", "Lion", "Buffalo"];
        string[] newAnimals = { "Zebra", "Gazelle", "Buffalo", "Zebra" };

        public void AddAnimals(string[] animalString)
        {
            foreach (string animal in animalString)
            {
                if (animalMap.ContainsKey(animal))
                {
                    animalMap[animal]++;
                }
                else
                {
                    animalMap[animal] = 1;
                }
            }
        }

        public void displayAnimals()
        {
            foreach(var animal in animalMap)
            {
                Console.WriteLine($"{animal.Key}{animal.Value}");
            }
        }

    }
}


