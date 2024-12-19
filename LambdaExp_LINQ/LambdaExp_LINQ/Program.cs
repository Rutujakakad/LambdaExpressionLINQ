// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Runtime.Intrinsics.X86;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using LambdaExp_LINQ;
using System.Collections;



//class Progarm
//{
//static void Main(string[] args)
// {  //==============================================================Example1
//    // List with each element of type Student
//    List<Student> details = new List<Student>()
//    {
//            new Student{ rollNo = 1, name = "Liza" },
//            new Student{ rollNo = 2, name = "Stewart" },
//            new Student{ rollNo = 3, name = "Tina" },
//            new Student{ rollNo = 4, name = "Stefani" },
//            new Student { rollNo = 5, name = "Trish" }
//    };


//    var newDetails = details.OrderBy(x => x.name);

//    foreach (var value in newDetails)
//    {
//        Console.WriteLine(value.rollNo + " " + value.name);
//    }

//    ////===============================================================Example2

//    List<int> numbers = new List<int>() { 10, 18, 12, 5, 9, 20 };


//    Console.Write("The list : ");
//    foreach (var value in numbers)//foreach loop to display the list
//    {
//        Console.Write("{0} ", value);
//    }
//    Console.WriteLine();

//    var square = numbers.Select(x => x * x);

//    // foreach loop to display squares
//    Console.Write("Squares : ");
//    foreach (var value in square)
//    {
//        Console.Write("{0} ", value);
//    }
//    Console.WriteLine();

//    List<int> divBy2 = numbers.FindAll(x => (x % 2) == 0);

//    // foreach loop to display divBy2
//    Console.Write("Numbers Divisible by 2 : ");
//    foreach (var value in divBy2)
//    {
//        Console.Write("{0} ", value);
//    }
//    Console.WriteLine();

//    // ======================================================================
//    // Practise problem during Session
//    List<Person> per = new List<Person>()
//    {

//           new Person{SSn = 1, Name = "John",Address = "Mumbai", Age = 35},
//           new Person{SSn = 2, Name = "Arex",Address = "Pune", Age = 26},
//           new Person{SSn = 3, Name = "Liza",Address = "Banglore", Age = 15},
//           new Person{SSn = 4, Name = "Alex",Address = "Hydrabad", Age = 65},
//           new Person{SSn = 4, Name = "Tiya",Address = "Odisha", Age = 30},


//    };
//    // var newDetails = details.OrderBy(x => x.name);
//    foreach (var newPerson in per)
//    {
//        var Age = per.Where(whr => whr.Age < 60).ToList();

//        //var AgeBetween = per.Where(whr => whr.Age > 60).ToList();
//        Console.WriteLine(newPerson.SSn + " " + newPerson.Name + " " + newPerson.Address + " " + newPerson.Age);
//    }

//    //=================age between 13 and 18
//    Console.WriteLine("age between 13 and 18");
//    foreach (var newPerson in per.FindAll(x => x.Age >= 13 && x.Age <= 18))
//    {
//        Console.WriteLine(newPerson.Name + " " + newPerson.Name + " " + newPerson.Address + " " + newPerson.Age);

//    }

//    //==================Avg
//    Console.WriteLine("Average is: ");
//    var Average = per.Average(x => x.Age);
//    Console.WriteLine($"Average: {Average}");

//    //===================name is present or not=========
//    var check = per.Any(n => n.Name.Equals("Rutuja"));
//    if (check) Console.WriteLine("Present");
//    else Console.WriteLine("Absent");


//    //=====================================implementation of examples 


//List<Employee> emp = new List<Employee>()
//{
//        new Employee { Id = 101, Name = "Riya", Salary = 32000, Department = "IT" },
//        new Employee { Id = 102, Name = "Tina", Salary = 20000, Department = "Management" },
//        new Employee { Id = 103, Name = "Saurav", Salary = 50000, Department = "Sales" },
//        new Employee { Id = 104, Name = "Raj", Salary = 30000, Department = "Finance" },
//        new Employee { Id = 105, Name = "Alana", Salary = 40000, Department = "Finance" },
//};


//    //Lambda Expression
//var empdetails = emp.Select(x =>x.Name).ToList();
//foreach (var item in empdetails)
//{
//    Console.WriteLine(item);

//}
//var department = emp.Select(x => x.Department).ToList();
//foreach (var item in department)
//{
//    Console.WriteLine(item);

//}

//var salary = emp.Select(x => x.Salary).ToList();
//foreach (var item in salary)
//{
//    Console.WriteLine(item);

//}
//var ID = emp.Select(y => y.Id).ToList();
//foreach (var item in ID)
//{
//    Console.WriteLine(item);
//}

////LINQ methods

//var MethodSyntax = Employee.GetEmployees().ToList();

//foreach (var item in MethodSyntax)
//{
//    Console.WriteLine(item);

//}

//var QuerySyntax = (from Emp in Employee.GetEmployees()
//                   select emp).ToList();

//foreach (var Emp in QuerySyntax)
//{
//    Console.WriteLine(Emp); //THROWING GARBAGE COLLECTION
//}
//Console.ReadKey();
//==============================================================================================
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 30, 40, 15, 8 };

        var MethodSyntax = arr.Where(whr => whr > 30);
      // var MethodSyntax = arr.Distinct();.
        foreach (int i in MethodSyntax)
        {
            Console.WriteLine(i);
        }

        var QuerySyntax = (from no in arr where no > 2 select no);
        foreach (int i in QuerySyntax)
        {
            Console.WriteLine(i);
        }

        var methodSyntax = arr.ElementAt(3);
        Console.WriteLine(methodSyntax);

        var MethodSyntx = arr.ElementAtOrDefault(60);
        Console.WriteLine($"MethodSyntx: {methodSyntax}");

        var MethodContain = arr.Contains(30);
        Console.WriteLine(MethodContain);

        
        var MethodLast = arr.Last();
        Console.WriteLine(MethodLast);


    }
}
    
        
    
        
