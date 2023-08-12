using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Exception_TryCatchBlock
{
    class Program : IDisposable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int k = 10;
            for (int i = 0; i < k; i++)
            {
                int d = i;
            }

            //Add(33333,43333);
            Add(20.3,2.5);



            GetReturnInt();
            Console.ReadLine();
            
        }

        private static int GetReturnInt()
        {
            try
            {

                
                Dictionary<int, string> table = new Dictionary<int, string>();
                table.Add(1, "Data");
                table.Add(2, "Data");
                table.Add(3, "Data");
                table.Add(2, "Data");
                table.Add(2, "Data");
                table.Add(3, "Data");
                return 10;


            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Finally is getting Called");
            }

            
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
