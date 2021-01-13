using System;
using System.Collections.Generic;
using System.Text;

namespace LINQy
{
    static class Utitility
    {
        public static string Print(this List<Student> students)
        {
            string printOut = "";
            foreach (var student in students)
            {
                printOut += $"{student.StudentName} \t{student.Age}\n";
            }
            return printOut;
        }
        public static string Print(this List<WinningPeople> winningPeople)
        {
            string printOut = "";
            foreach (var winner in winningPeople)
            {
                printOut += $"{winner.Name} won {winner.Award:c} with a previous balance of {winner.Balance:c}\n";
            }
            return printOut;
        }

    }
}
