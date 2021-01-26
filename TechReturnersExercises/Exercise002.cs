using System;
using TechReturners.Exercises;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person)
        {
            return person.City == "Manchester";
        }
        // {

        //     bool result = person.City == "Manchester" ? true : false;

        //     return result;
        // }


        public static bool CanWatchFilm(Person person, int ageLimit)
        {

            bool result = person.Age >= ageLimit ? true : false;

            return result;
        }
    }
}
