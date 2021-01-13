using System;
using System.IO;

namespace CustomerApp
{
    public class GenericError : ILogger
    {
        public void Handle(string error)
        {
            File.WriteAllText(@"C:\Error.txt", error);
            Console.WriteLine("Generic Error");
        }
    }
}
