using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ParentClass parentClass = new ParentClass();

            ParentClass parentClass1 = new ChildClass();

            ChildClass childClass = new ChildClass();

            //ChildClass childClass1 = new ParentClass();
        }


    }

    public class ParentClass
    {
        public void ParentClassMethod()
        {

        }
    }

    public class ChildClass: ParentClass
    {
        

    }
}
