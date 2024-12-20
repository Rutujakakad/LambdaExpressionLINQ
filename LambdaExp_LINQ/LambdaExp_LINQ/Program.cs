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



class Progarm
{
    static void Main(string[] args)
    {
        Employee.Display();
        Employee.Distinct();
        Employee.First();
        Employee.OrderBy();
        Student.First();
        Student.distinct();
        Student.Contains();

        Student.Details();
        Person.Ages();
        Person.FindAll();
        Person.Names();
        Employee.LambdaExpression();
    }
}
     
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
        

        


        


        //==============================================================================================
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 30, 40, 15, 8 };

//        var MethodSyntax = arr.Where(whr => whr > 30);
//      // var MethodSyntax = arr.Distinct();.
//        foreach (int i in MethodSyntax)
//        {
//            Console.WriteLine(i);
//        }

//        var QuerySyntax = (from no in arr where no > 2 select no);
//        foreach (int i in QuerySyntax)
//        {
//            Console.WriteLine(i);
//        }

//        var methodSyntax = arr.ElementAt(3);
//        Console.WriteLine(methodSyntax);

//        var MethodSyntx = arr.ElementAtOrDefault(60);
//        Console.WriteLine($"MethodSyntx: {methodSyntax}");

//        var MethodContain = arr.Contains(30);
//        Console.WriteLine(MethodContain);

        
//        var MethodLast = arr.Last();
//        Console.WriteLine(MethodLast);


//    }

    
        
    
        
