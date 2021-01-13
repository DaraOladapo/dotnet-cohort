using System;

namespace CustomerApp
{
    public class MyException : Exception, ILogger
    {
        public void Handle(string error)
        {
            Console.WriteLine("My custom Error");
        }
    }
}
