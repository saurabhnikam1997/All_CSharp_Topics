using System;

namespace Ref_And_Out
{
    class Program
    {

        // Property or indexer cannot be passed as a ref or out parameter to a method
        public static int num1 { get; set; }


        // calling method
        static void Main()
        {
            Console.WriteLine("Hello World!");
            var count = 0;
            // ref
            // ref parameter must be initialized before passing it to the method  as a ref
            // data can be passed bi-directionally i.e, from calling method to called method and called method to calling method
            // out 
            // it is not mandatory to assign or initialize the value of out parameter before passing it to the method as a out
            // data moves only in unidirectionally i.e, from called method to calling method

            int a = 10;
            int b;
            int k = 5;
            AddNums(ref a, out b, num1 ,ref count ,k);
            Console.WriteLine($"After ref and out a= {a}, b={b}");
            Console.ReadLine();
        }

        //called method
        public static void AddNums(ref int x, out int y, int num, ref int cnt, int k)
        {
            // out
            // Out parmater must be assigned some value before control leaves the current method(called method)
            // using out params single method can return multiple values
            // Console.WriteLine($"Result is : {x + y}"); this line gives compile time error because the valye of out parameter y is not assigned.

            y = x + 15; // this out param must be assigned or initialized
            Console.WriteLine($"{y}");

            // ref 
            // it not mandatory to initialize or assigned value to the ref parameter in callied method
            // x += 12;
            Console.WriteLine($"{x}");
            Console.WriteLine($"Result is : {x+y+k}");

            cnt = 12;
        }
    }
}
