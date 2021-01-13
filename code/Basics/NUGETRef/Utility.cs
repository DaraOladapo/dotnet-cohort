using System;
using System.Collections.Generic;
using System.Text;

namespace NUGETRef
{
    static class Utility
    {
        public static void Print(this List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}'s email address is {person.EmailAddress}");
            }
        }
    }
}
