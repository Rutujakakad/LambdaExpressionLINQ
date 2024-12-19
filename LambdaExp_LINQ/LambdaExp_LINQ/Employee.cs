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
            };
            return emp;
        }
       
    }
}
