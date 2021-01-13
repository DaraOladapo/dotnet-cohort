using System;

namespace EventExample
{
    class Program
    {
        static void MaximumReached(object source, MyEventArgs e)
        {
            Console.WriteLine(e.GetInfo());
        }
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            myObject.OnMaximum += new MyEventHandler(MaximumReached);
            for (int x = 0; x <= 15; x++)
            {
                myObject.MyValue = x;
            }
            Console.ReadLine();
        }
    }
    public delegate void MyEventHandler(object source, MyEventArgs e);
    public class MyEventArgs : EventArgs
    {
        private string EventInfo;
        public MyEventArgs(string Text)
        {
            EventInfo = Text;
        }
        public string GetInfo()
        {
            return EventInfo;
        }
    }
    public class MyClass
    {
        public event MyEventHandler OnMaximum;
        private int i;
        private int Maximum = 10;
        public int MyValue
        {
            get
            {
                return i;
            }
            set
            {
                if (value <= Maximum)
                {
                    i = value;
                }
                else
                {
                    //To make sure we only trigger the event if a handler is present
                    //we check the event to make sure it's not null.
                    if (OnMaximum != null)
                    {
                        OnMaximum(this, new MyEventArgs("You've entered " + value.ToString() +
                            ", but the maximum is " + Maximum.ToString()));
                    }
                }
            }
        }
    }
    class Counter
    {
        public event EventHandler ThresholdReached;
        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            handler?.Invoke(this, e);
            //if (handler != null)
            //{
            //    handler.Invoke(this, e);
            //}
        }
    }
}
