using Lab01;


namespace LabExercise3
{
    public class Lab3Exercises
    {
        

        public int GetInt(string inputPrompt)
        {
            int num = 0;
            Console.WriteLine(inputPrompt); 
            
            
            string userInput = Console.ReadLine();
            bool isParsed = int.TryParse(userInput, out num);
            
            if (!isParsed)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                num = 0; 
            }

            return num;
        }

        public string GetString(string inputPrompt)
        {
            Console.WriteLine(inputPrompt);

            string userInput = Console.ReadLine();
            userInput.Trim();

            if (userInput == null) {
                Console.WriteLine("Invalid input. Please enter a valid string.");
            }

            return userInput;
        }

        
    }
}