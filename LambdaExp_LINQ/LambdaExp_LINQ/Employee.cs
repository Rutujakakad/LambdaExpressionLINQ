using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp_LINQ
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> emp = new List<Employee>()
            {
               new Employee { Id = 101, Name = "Riya", Salary = 32000, Department = "IT" },
               new Employee { Id = 102, Name = "Tina", Salary = 20000, Department = "Management" },
               new Employee { Id = 103, Name = "Saurav", Salary = 50000, Department = "Sales" },
               new Employee { Id = 104, Name = "Raj", Salary = 30000, Department = "Finance" },
               new Employee { Id = 105, Name = "Alana", Salary = 40000, Department = "Finance" },
               new Employee { Id = 101, Name = "Riya", Salary = 32000, Department = "IT" },
            };
            return emp;
        }

        public static void Display()//Any()
        {   //methodsyntax======>
            var MethodSyntax = Employee.GetEmployees().Any(x => x.Salary >= 30000 && x.Department == "Finance");
            Console.WriteLine(MethodSyntax);
           
            //querysyntax========>
            var QuerySyntax = (from emp in Employee.GetEmployees() orderby emp.Salary select emp);
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item.Name + " " + item.Salary);
            }
        }

        public static void Distinct()
        {
            var methodSyntax = Employee.GetEmployees().Select(x => x.Name).Distinct().ToList();
            
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            var querySyntax = (from emp in Employee.GetEmployees() select emp.Name).Distinct().ToList();
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

        }
        public static void First()
        {
            var MethodSyntax = Employee.GetEmployees().First();
            Console.WriteLine($"Name: {MethodSyntax.Name} Department: {MethodSyntax.Department} Salary: {MethodSyntax.Salary}");


            //Query Syntax
            var QuerySyntax = (from emp in Employee.GetEmployees() select emp).First();
            Console.WriteLine($"Name: {QuerySyntax.Name} Department: {QuerySyntax.Department} Salary: {QuerySyntax.Salary}");
        }

        public static void OrderBy()
        {
            var MethodSyntax = Employee.GetEmployees().OrderBy(z => z.Name).ToList();
            foreach(var item in MethodSyntax)
            {
                Console.WriteLine($"Name: {item.Name}");
            }
        }
        public static void LambdaExpression()
        {
            var empdetails = GetEmployees().Select(x => x.Name).ToList();
            foreach (var item in empdetails)
            {
                Console.WriteLine(item);

            }
            var department = GetEmployees().Select(x => x.Department).ToList();
            foreach (var item in department)
            {
                Console.WriteLine(item);

            }

           
        }




    }
}
