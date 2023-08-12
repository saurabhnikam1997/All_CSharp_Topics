using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueData
{
    public class Program : IInterface1, IInterface2
    {
        static void Main(string[] args)
        {

            NormalClass nm = new NormalClass();
            nm.Add(4);

            // This is using LINQ
            Console.WriteLine("Hello World!");

            List<int> intList = new List<int> { 22, 22, 22, 33, 32, 35, 33, };
            intList.Add(12);

            foreach (var item in intList)
            {
                Console.Write(item +",");
            }

            Console.WriteLine("After");

            List<int> nList = intList.Distinct().ToList();

            foreach (var item in nList)
            {
                Console.Write(item+",");
            }

            HashSet<int> intHash11 = new HashSet<int>(intList);
            // using HashSet nd loop

            HashSet<int> intHash = new HashSet<int>();

            foreach (var item in intList)
            {
                intHash.Add(item);
            }

            List<int> uniqueList = new List<int>();
            foreach (var item in intList)
            {
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);

                }
            }
            Console.ReadLine();

            
        }

        public void GetMethod1()
        {
            throw new NotImplementedException();
        }

        public void GetMethod2()
        {
            throw new NotImplementedException();
        }
    }

    public interface IInterface1
    {
        void GetMethod1();
        void GetMethod2();
    }
    public interface IInterface2
    {
        void GetMethod1();
    }

    public class NormalClass : BaseClass
    {
        public override int Add(int a)
        {
            return base.Add(a);
        }
    }

    public abstract class ClassAbstract
    {
        public abstract void GetParams();

        public int GetNumber(int a, int b)
        {
            return a + b;
        }

    }

    public class BaseClass
    {
        public void CreateInstance()
        {

        }

        public virtual int Add(int a)
        {
            return a;
        }
    }
    public class BaseClass1
    {
        public void CreateInstance()
        {

        }

        public int Add(int a)
        {
            return a;
        }
    }
}
