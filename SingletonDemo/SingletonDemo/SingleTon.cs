using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    //Class ABC
    //Private constructor
    //a private instance in ABC of same type that should be static because we can call directly with the name of class
    //there should be a function or property which Creat/gives the instance
    // getinstance method should have return type of the same as class  // Line 32
    // Normal
    public sealed class SingleTon
    {
        private static int Counter = 0;
        private static readonly object obj = new object(); //why
        private static SingleTon Instance = null; //why static

        //public SingleTon CheckStatic()
        //{
        //    Console.WriteLine("Check Static");
        //    //How can we call this method
        //    //SingleTon.getInctance().CheckStatic();
        //    //SingleTon single = new SingleTon();
        //    //single.CheckStatic
        //    //we can call this method with the name of class
        //    //SingleTon.CheckStatic
        //    //When a member is declared static, it can be accessed with the name of its class directly.
        //}
        public static SingleTon getInstance()
        {
            //
            if (Instance == null)
            {
                lock (obj) // single threading
                {
                    if (Instance == null)
                        Instance = new SingleTon();
                }
            }

            return Instance;
        }
        public static SingleTon GetInstances // why static
        {
            get
            {
                if (Instance == null)
                {
                    lock (obj) // single threading
                    {
                        if (Instance == null)
                            Instance = new SingleTon();
                    }
                }

                return Instance;
            }
        }
        private SingleTon()
        {
            Counter++;
            Console.WriteLine("Counter Value:" + Counter.ToString());
        }
        public void PrintDetails(string message)
        {
            
            Console.WriteLine(message);
        }
    }

    //Eager loading
    //public sealed class SingleTon
    //{
    //    private static int Counter = 0;
    //    //private static readonly object obj = new object();
    //    private static readonly SingleTon Instance = new SingleTon();
    //    public static SingleTon GetInstances
    //    {
    //        get
    //        {
    //            return Instance;
    //        }
    //    }
    //    private SingleTon()
    //    {
    //        Counter++;
    //        Console.WriteLine("Counter Value:" + Counter.ToString());
    //    }
    //    public void PrintDetails(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}

    //Lazy loading
    //public sealed class SingleTon
    //{
    //    private static int Counter = 0;
    //    //private static readonly object obj = new object();
    //    private static readonly Lazy<SingleTon> Instance = new Lazy<SingleTon>(()=> new SingleTon());
    //    public static SingleTon GetInstances
    //    {
    //        get
    //        {
    //            return Instance.Value;
    //        }
    //    }
    //    private SingleTon()
    //    {
    //        Counter++;
    //        Console.WriteLine("Counter Value:" + Counter.ToString());
    //    }
    //    public void PrintDetails(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}
}
