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
            book.ShowStatistics();
        }
    }
}
