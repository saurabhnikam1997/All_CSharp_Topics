using System;
using System.Threading.Tasks;

namespace SingletonDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parallel.Invoke(
                () => GetFirstInstance(),
                ()=> GetSeconsInstance()
            );
      

            Console.WriteLine("........................");

            Console.ReadLine();
        }

        private static void GetSeconsInstance()
        {
            SingletonClass SecondInstance = SingletonClass.GetSingletonInstance;
            Console.WriteLine(SecondInstance.Add(22, 22));
        }

        private static void GetFirstInstance()
        {
            SingletonClass firstInstance = SingletonClass.GetSingletonInstance;
            Console.WriteLine(firstInstance.Add(3, 4));
        }
    }
}
