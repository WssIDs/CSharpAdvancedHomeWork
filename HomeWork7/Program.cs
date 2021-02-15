using System;
using System.Collections.Generic;
using HomeWork7.Context;
using HomeWork7.Entities;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolDbContext();
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Анатолий",
                    LastName = "А",
                    Course = 3,
                    Description = "Описание 1"
                },
                new Student
                {
                    FirstName = "Владимир",
                    LastName = "Б",
                    Course = 4
                },
                new Student
                {
                    FirstName = "Анна",
                    LastName = "С",
                    Course = 1
                },
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
