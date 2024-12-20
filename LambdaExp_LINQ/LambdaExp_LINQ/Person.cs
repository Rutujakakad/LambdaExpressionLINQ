using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp_LINQ
{
    internal class Person
    {
        public int SSn {  get; set; }
        public string Name {  get; set; }
        public string Address {  get; set; }
        public int Age {  get; set; }

        public static List<Person> GetList()
        {
            List<Person> per = new List<Person>()
            {
               new Person{SSn = 1, Name = "John",Address = "Mumbai", Age = 35},
               new Person{SSn = 2, Name = "Arex",Address = "Pune", Age = 26},
               new Person{SSn = 3, Name = "Liza",Address = "Banglore", Age = 15},
               new Person{SSn = 4, Name = "Alex",Address = "Hydrabad", Age = 65},
               new Person{SSn = 4, Name = "Tiya",Address = "Odisha", Age = 30},
            };
            return per;
        }

        public static void Ages()//OrderBy(),Where(),FindAll()
        {
            var newDetails =Person.GetList().OrderBy(x => x.Name);
            foreach (var newPerson in newDetails)
            {
                var Age =Person.GetList().Where(whr => whr.Age > 60);

                //var AgeBetween = per.Where(whr => whr.Age > 60).ToList();
                Console.WriteLine(newPerson.SSn + " " + newPerson.Name + " " + newPerson.Address + " " + newPerson.Age);
            }
            
        }

        public static void FindAll()
        {
            Console.WriteLine("age between 13 and 18");
            var Between = Person.GetList().OrderBy(x => x.Name);
            foreach (var newPerson in Between)
            {
                var AgeBetween = GetList().FindAll(x => x.Age >= 13 && x.Age <= 18);
            
                Console.WriteLine(newPerson.SSn + " " + newPerson.Name + " " + newPerson.Address + " " + newPerson.Age);

            }

            //==================Avg
            Console.WriteLine("Average is: ");
            var Average = GetList().Average(x => x.Age);
            Console.WriteLine($"Average: {Average}");
        }

        public static void Names()
        {
            var check = GetList().Any(n => n.Name.Equals("Rutuja"));
               if (check) Console.WriteLine("Present");
               else Console.WriteLine("Absent");
        }
    }
}
