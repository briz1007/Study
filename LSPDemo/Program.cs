using LSPDemo.Abstract;
using LSPDemo.Implementation;
using LSPDemo.Interface;
using System;

namespace LSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TempEmployee(2, "Jason"));
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach(var employee in employees)
            {
                Console.WriteLine(string.Format("Employee: {0} Bonus: {1} Min: {2}", employee.ToString(),
                employee.CalculateBonus(100000).ToString(), employee.GetMinimumSalary().ToString()));
            }

            //Console.WriteLine(string.Format("Employee: {0} Bonus: {1}", empJohn.ToString(),
            //    empJohn.CalculateBonus(100000).ToString()));
            //Console.WriteLine(string.Format("Employee: {0} Bonus: {1}", empJason.ToString(),
            //    empJason.CalculateBonus(150000).ToString()));
            //Console.WriteLine(string.Format("Employee: {0} Bonus: {1}", empMike.ToString(),
            //    empMike.CalculateBonus(150000).ToString()));

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();
            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TempEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));
            foreach (var employe in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee: {0} mini salary: {1}", employe.ToString(),
                employe.GetMinimumSalary().ToString()));
            }

            Console.ReadLine();

        }
    }
}