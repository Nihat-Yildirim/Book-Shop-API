namespace BookShopAPI.Application.Helpers.RandomNumber
{
    public static class RandomNumberHelper
    {
        public static string GenerateNumberToString(int numberOfDigits)
        {
            string createdNumber = string.Empty;
            string selectedNumber;
            Random random = new Random();

            for (int i = 1; i <= numberOfDigits; i++)
            {
                if (i == 1)
                {
                    selectedNumber = random.Next(1, 10).ToString();
                    createdNumber = createdNumber + selectedNumber;
                }

                if (i > 1)
                {
                    selectedNumber = random.Next(0, 10).ToString();
                    createdNumber = createdNumber + selectedNumber;
                }
            }

            return createdNumber;
        }

        public static int GenerateNumber(int numberOfDigits)
        {
            return Convert.ToInt32(GenerateNumberToString(numberOfDigits));
        }
    }
}