using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_q1
{
    class Data
    {
        public static List<Employee> Employees = new List<Employee>();
        public static void PrintEmployee()
        {
            Console.WriteLine("Please enter the employee Name");
            String key =Console.ReadLine();
            var emp = (from Employee in Employees where Employee.Name == key select Employee);
            Console.WriteLine("\nDetails of the employee with name "+key+"\n");
            foreach (var i in emp)
            {
                Console.WriteLine(i);
            }
        }
        public static void SortAndPrintEmployees()
        {
            Employees.RemoveAt(Employees.Count - 1);
            Data.Employees.Sort();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nEmployee list after sorting \n");
            Data.Employees.ForEach(employee => Console.WriteLine(employee));
            Console.WriteLine("-------------------------------------");


        }

    }
}