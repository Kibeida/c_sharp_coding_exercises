using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word)
        {

            return (char.ToUpper(word[0]) + word.Substring(1));


        }

        public static String GenerateInitials(String firstName, String lastName)
        {


            char fName = char.ToUpper(firstName[0]);
            char lName = char.ToUpper(lastName[0]);

            return $"{fName}.{lName}";

        }

        public static double AddVat(double originalPrice, double vatRate)
        {

            double vat = originalPrice * vatRate / 100;
            double result = originalPrice + vat;

            return Math.Round(result, 2);

        }

        public static String Reverse(String sentence)
        {

            var charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            var result = new String(charArray);
            return result;
        }

        public static int CountLinuxUsers(List<User> users)
        {

            int result = 0;

            foreach (var user in users)
            {
                if (user.Type == "Linux") result += 1;
            }

            return result;
        }
    }
}
