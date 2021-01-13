using System;

namespace CustomerApp
{
    public class FileException : Exception, ILogger
    {
        public void Handle(string Error)
        {
            Console.WriteLine("Generic Error");
        }

    }
}
