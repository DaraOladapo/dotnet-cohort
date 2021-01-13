using System;
using System.Linq;

namespace FunStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input a string:");
            //var inputString = Console.ReadLine();
            //Console.WriteLine($"{inputString} sorted: {GetSortedString(inputString)}");
            Console.WriteLine($"(1, 3, true) -> {BooleyInt(1, 3, true)}");
            Console.WriteLine($"(3, 3, false) -> {BooleyInt(3, 3, false)}");
            Console.WriteLine($"(1, 1, true) -> {BooleyInt(1, 1, true)}");
        }
        static int BooleyInt(int firstVal, int secondVal, bool thirdVal)
        {
            //var returnValue = thirdVal ? firstVal + secondVal : firstVal * secondVal;
            //return returnValue;
            return thirdVal ? firstVal + secondVal : firstVal * secondVal;
        }
        //static string GetSortedString(string inputString)
        //{
        //    var sortedCharArray = inputString.OrderBy(c=>c.ToString());
        //    string sortedString = "";
        //    foreach (var item in sortedCharArray)
        //    {
        //        sortedString += item;
        //    }
        //    return sortedString;
        //}

        //using Ascii Values
        //static string GetSortedString(string inputString)
        //{
        //    var charArray = inputString;
        //    string returnString = "";

        //    int[] AsciiVals = new int[charArray.Length];
        //    for (int i = 0; i < charArray.Length; i++)
        //    {
        //        int asciiValue = (int)charArray[i];
        //        AsciiVals[i] = asciiValue;
        //    }
        //    Array.Sort(AsciiVals);
        //    foreach (var sortedCharVal in AsciiVals)
        //    {
        //        char convertedChar = (char)sortedCharVal;
        //        returnString += convertedChar;
        //    }
        //    return returnString;
        //}


    }
}
