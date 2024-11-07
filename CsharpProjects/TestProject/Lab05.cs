namespace Lab05
{
    class Lab5
    {
        public void Grades(int score)
        {
            string grade = "";

            if(score >= 70 )
            {
                grade = "Distinction";
            }
            else if (score >= 60)
            {
                grade = "Merit";   
            }
            else if (score >= 50 )
            {
                grade = "Pass";
            }
            else 
            {
                grade = "Fail";
            }

            Console.WriteLine($"Your grade is {grade}!");
            return;
        }

        public void Part2(string season, string evening)
        {
            bool isSummer = false;
            bool isEvening = false;
            string action = "";

            if(season == "yes")
            {
                isSummer = true;
            }

            if (evening == "yes")
            {
                isEvening = true;
            }

            if (isSummer && isEvening)
            {
                action = "Take a shower, Eat outside, Do an outdoor hobby and Contact friends!";
            }
            else if (isSummer && !isEvening)
            {
                action = "Take a shower, eat inside, do an outdoor hobby and contact friends!";
            }
            else if (isEvening && !isSummer)
            {
                action = "Take a shower, eat inside, take a walk and contact friends!";
            }
            else
            {
                action = "Take a shower, eat inside and contact friends!";
            }

            Console.WriteLine($"Here are your actions for the evening:\n{action}");
            return;

        }
    } 
}