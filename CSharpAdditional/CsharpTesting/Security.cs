namespace TestIntroduction
{
    public class Security
    {

        public string ErrorMessage { get; set; }

        public bool Logon(string userId, string password)
        {

            if (userId == null || userId.Trim() == "")
            {

                ErrorMessage = "UserID may not be null or empty";

                return false;

            }

            else if (password == null || password.Trim() == "")
            {

                ErrorMessage = "Password may not be null or empty";

                return false;

            }

            else if (!validatePassword(password))
            {

                ErrorMessage = "Min 8 chars with an uppercase and a number";

                return false;

            }

            else
            {

                ErrorMessage = "";

                return true;

            }

        }

        private bool validatePassword(string password)
        {

            bool hasUpper = false, hasDigit = false;

            if (password.Length < 8)

                return false;

            foreach (char c in password)
            {

                if (char.IsUpper(c))
                {

                    hasUpper = true;

                    continue; // continue loop as no char can be upper and digit

                }

                if (char.IsDigit(c))

                    hasDigit = true;

            }

            return hasUpper && hasDigit;

        }

    }
}