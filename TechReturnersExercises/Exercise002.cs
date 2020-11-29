using System;
using TechReturnersExercises;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person) 
        {
            // Add your code here!
            
             if(person.City == "Manchester") {
                 return true;
            }  else
            {
                return false;
            }
        }

        public static bool CanWatchFilm(Person person, int ageLimit) 
        {
            // Add your code here!
            
            if(person.Age >= ageLimit) {
                 return true;
            }  else
            {
                return false;
            }
        }
    }
}
