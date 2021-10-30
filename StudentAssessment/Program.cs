using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAssessment
{
    public class Program
    {
        private static string _name;
        private static char _grade;
        private static double _total;

        public static void Main(string[] args)
        {
            Console.WriteLine("<<MARKS CALCULATOR>>");
            Console.WriteLine("<<================>>");
            Console.WriteLine("Enter your name to display your results ");
            Console.Write("Enter Student Name: ");
            _name = Console.ReadLine();
            Console.WriteLine();

            Dictionary<string, double> subjectMarks = new();
            subjectMarks.Add("English", 98.2);
            subjectMarks.Add("Core Mathematics", 89);
            subjectMarks.Add("Int. Science", 79);
            subjectMarks.Add("Social Studies", 88.6);
            subjectMarks.Add("Programming with C++:", 76);
            subjectMarks.Add("I.T Tools", 86);
            subjectMarks.Add("Artificial intelligence", 79);
            subjectMarks.Add("Digital Electronics", 69.5);

            Console.WriteLine("Below are your results\n");
            Console.WriteLine("===================== ");
            foreach (var subjectMark in subjectMarks)
            {
                Console.WriteLine($"{subjectMark.Key} | " +
                                  $"Marks: {subjectMark.Value}, " +
                                  $"Grade: {Grading.GetGrade(subjectMark.Value)}, " +
                                  $"Remarks: {Grading.GetRemarks(subjectMark.Value)}");
            }
            Console.WriteLine();

            Console.WriteLine($"Hello {_name}, your total marks for the {subjectMarks.Keys.Count} subjects is {subjectMarks.Values.Sum()}");

            Console.ReadLine();
        }
    }
}