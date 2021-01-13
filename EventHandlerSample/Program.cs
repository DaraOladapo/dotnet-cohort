using System;

namespace EventHandlerSample
{
    public delegate string MyDel(string str);
    class Program
    {

        event MyDel MyEvent;

        public Program()
        {
            MyEvent += new MyDel(WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return $"Welcome {username}";
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            string result = program.MyEvent("QA is awesome");
            Console.WriteLine(result);
        }
    }
}
