using ADO.net_Lab;
using ADO.net_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADO.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> values = new List<string>();
            //values.Add("Jon");
            //values.Add("Doe");
            //values.Add("Ram");
            //values.Add("Jay");
            //values.Add("Dave");
            //values.Add("Pat");

            //foreach(string val in values)
            //{
            //    Console.WriteLine(val);
            //}

            //string firstValue = values.First();
            //string lastValue = values.Last();
            //Console.WriteLine(firstValue);
            //Console.WriteLine(lastValue);

            //var valuesWithY = values.Where(v => v.Contains("Y"));
            //var firstValueWithContaingY = valuesWithY.FirstOrDefault();
            //Console.WriteLine("\n");
            //Console.WriteLine(firstValueWithContaingY);

            //foreach (string val in valuesWithY)
            //{
            //    Console.WriteLine(val);
            //}

            List<Student> students = new StudentDAL().GetStudents().ToList();
            List<SMarks> marks = new StudentDAL().GetMarks().ToList();

            //var result = students.GroupBy(s => s.Year);

            //var result = from student in students
            //             group student.ID by student.Year into g
            //             select new { Year = g.Key, Count = g.Count() };

            //foreach (var res in result)
            //{
            //    Console.WriteLine(res.Year + " " + res.Count);
            //}

            //var joinResult = (from student in students
            //                  join mark in marks on student.ID equals mark.StudentID
            //                  select new
            //                  {
            //                      student.ID,
            //                      student.Name,
            //                      student.Year,
            //                      mark.Marks
            //                  }).ToList();

            //foreach (var res in joinResult)
            //{
            //    Console.WriteLine(res.ID + " " + res.Name + " " + res.Year + " " + res.Marks);
            //}

            var studentsFrom2020 = students.Where(s => s.Year == "2020").Select(s=> s.Name);
            var studentsFrom2021 = students.Where(s => s.Year == "2021").Select(s => s.Name);
            var result = studentsFrom2020.Union(studentsFrom2021);
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }

    }
}
