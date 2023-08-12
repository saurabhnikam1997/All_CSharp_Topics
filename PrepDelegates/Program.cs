using System;
using System.Collections.Generic;

namespace PrepDelegates
{
    //public delegate void HelloFunctionDelegate(string msg); // its like method signatuer with delegate keyword
    public class Program
    {
        // A Delegate is a type safe function pointer
        static void Main(string[] args)
        {
            //HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            //del("Hello From delegate");

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID =101, Name="Mary", Salary=5000,Experience=5});
            empList.Add(new Employee() { ID =102, Name="Mike", Salary=4000,Experience=4});
            empList.Add(new Employee() { ID =103, Name="John", Salary=6000,Experience=6});
            empList.Add(new Employee() { ID =104, Name="Todd", Salary=3000,Experience=3});

            //IsPromotable isPromotable = new IsPromotable(Promote);

           // Employee.PromoteEmployee(empList, isPromotable);

            Employee.PromoteEmployee(empList, emp=> emp.Experience >= 5);
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage );
        }

        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }

    public delegate bool IsPromotable(Employee empl);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> empList, IsPromotable isEligibleToPromote)
        {
            //foreach (Employee employee in empList)
            //{
            //    if (employee.Experience >= 5)
            //    {
            //        Console.WriteLine(employee.Name + " is promoted");
            //    }
            //}
            foreach (Employee employee in empList)
            {
                if (isEligibleToPromote(employee)) //here it is calling particular delegate and its returning bool result in current case
                {
                    Console.WriteLine(employee.Name + " is promoted");
                }
            }
        }
    }
}
