using System;

namespace DelegateTask
{
    class Del
    {
        public delegate void exDel(string msg);
        static void Main(string[] args)
        {
            //exDel del = Ex1.Message;
            //del("Hello World");
            ////del("Today is a beautiful day");
            //del = Ex2.Message;
            //del("Hello World");
            var addition = Calculate(5, 10, Add);
            Console.WriteLine(addition);
            var subtraction = Calculate(5, 10, Substract);
            Console.WriteLine(subtraction);
        }
        static int Calculate(int a, int b, Func<int, int, int> valueCal)
        {
            var calculation = valueCal(a, b);
            return calculation;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Substract(int a, int b)
        {
            return a > b ? a - b : b - a;
        }
    }
    class Ex1
    {
        public static void Message(string message)
        {
            Console.WriteLine("Called Ex1.Message1() with parameter: " + message);
        }
    }
    class Ex2
    {
        public static void Message(string message)
        {
            Console.WriteLine("Called Ex2.Message() with parameter: " + message);
        }
    }
}
