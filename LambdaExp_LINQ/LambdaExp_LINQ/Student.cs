using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp_LINQ
{
    internal class Student
    {
        public int rollNo { get; set; }

        public string name { get; set; }
        public static List<Student> GetStudent()
        { 
            List<Student> details = new List<Student>()
            {
               new Student{ rollNo = 1, name = "Liza" },
               new Student{ rollNo = 2, name = "Stewart" },
               new Student{ rollNo = 3, name = "Tina" },
               new Student{ rollNo = 4, name = "Stefani" },
               new Student { rollNo = 5, name = "Trish" },
               new Student{ rollNo = 6, name = "Liza" }
            };
            
             return details;
        }

        public static void Details()
        {
            var newDetails = GetStudent().OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }
        }
        public static void First()
        {
            var Methodsyntax = Student.GetStudent().First();
            Console.WriteLine($"Roll no: {Methodsyntax.rollNo} Name: {Methodsyntax.name}");
        }

        public static void distinct()
        {
            var querysyntax = (from details in Student.GetStudent() select details.name).Distinct();
            foreach (var value in querysyntax)
            {
                Console.WriteLine(value);
            }
        }      

        public static void Contains()
        {
            var MethodSyntax = Student.GetStudent().Select(s=> s.name).Contains("Tina");

            //Using Query Syntax
            //*var QuerySyntax = (from name in namesList select name).Contains("vishal"*/);

            Console.WriteLine($"Name Exist: {MethodSyntax}");
            //Console.WriteLine($"Name Exist: {QuerySyntax}");

        }








    }
}
