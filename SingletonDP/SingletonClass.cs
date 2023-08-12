using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDP
{

    // 1. Make Constructor Private
    // 2. Create a Global singleton instance private property and method to access it.
    // 3. apply double check locking for thread safe implementation of Singleton.
    public sealed class SingletonClass
    {
        private static readonly Lazy<SingletonClass> _instance = new Lazy<SingletonClass>(()=>new SingletonClass());
        //private static readonly object lockobject = new object(); 
        public static SingletonClass GetSingletonInstance 
        { 
            get
            {
                return _instance.Value;
            }
        }
        static int count = 0;
        private SingletonClass()
        {
            count++;
            Console.WriteLine("object count: " + count.ToString());
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
