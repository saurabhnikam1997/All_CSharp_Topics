using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodDemo
{
    //Extension Method
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string myString = "This is my, extension method";
           int cnt = myString.WordCount();
            Console.WriteLine(cnt);

            List<Employee> emp = null;
            emp.IsNullOrEmpty();

            emp = new List<Employee> { new Employee { Id=1,Name="sau"} };
            if (emp.IsNullOrEmpty<Employee>())
            {
                Console.WriteLine("Collection is Empty");
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //Adding extension method WordCount to the inbuilt "string" Type by extending its functionality
    /// <summary>
    /// 1. It should be defined as a static method in a static class.
    /// 2. They should be Top level static class and cannot be nested within another class.
    /// 3. first param of Extension method-> the class/Type being extended preceded by "this" keyword
    ///                         -this param usually a first parameter, but it must be appear before additional parameter.
    /// </summary>
    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] {' ','.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;

            //return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    /*In the example above, the WordCount method is defined as an extension method for the string type. The this keyword before the first parameter (str) indicates that this method extends the string type. You can then use this method as if it were a member of the string class:*/

    public static class CollectionExtension
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || !collection.Any();
        }
    }
}
