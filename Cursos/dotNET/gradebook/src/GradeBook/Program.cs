using System;
using System.Collections.Generic;
using GradeBoook;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {            
            var book = new Book("Alessandro Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();

            System.Console.WriteLine($"The losest grade is {stats.Low}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The avarege grade is {stats.Average:N1}");   

        }
    }
}
