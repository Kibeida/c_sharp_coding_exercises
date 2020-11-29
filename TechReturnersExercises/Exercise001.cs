using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word) 
        {
            // Add your code here!
            return (char.ToUpper(word[0]) + word.Substring(1));

            throw new NotImplementedException();
        }

        public static String GenerateInitials(String firstName, String lastName) 
        {
            // Add your code here!

            char fName = char.ToUpper(firstName[0]);
            char lName = char.ToUpper(lastName[0]);

            return $"{fName}.{lName}";
             
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            // Add your code here!
            double vat = originalPrice * vatRate / 100;
            double result = originalPrice + vat;
            
            return Math.Round(result,2);
           
        }

        public static String Reverse(String sentence) 
        {
            // Add your code here!
            var charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            var result = new String(charArray);
            return result;
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            // Add your code here!
            int result = 0;

            foreach (var user in users)
            {
                if (user.Type == "Linux") result += 1;
            }

            return result;
        }
    }
}
