using System;

namespace Pratik1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Students
            Person student = new Person
            {
                Name = "Furkancan",
                Surname = "Yilmaz",
                Age = 24,
                BirthDate = new DateTime(2000, 12, 22),
            };

            Person student2 = new Person
            {
                Name = "Azra",
                Surname = "Ozmentese",
                Age = 21,
                BirthDate = new DateTime(2003, 05, 27),
            };

            //Teacher
            Person teacher = new Person
            {
                Name = "Sertan",
                Surname = "Bozkus",
                Age = 33,
                BirthDate = new DateTime(1990, 3, 15),
            };
            Person teacher2 = new Person
            {
                Name = "Kerim",
                Surname = "Cevik",
                Age = 28,
                BirthDate = new DateTime(1995, 8, 8),
            };



            // Nesneleri konsola yazdırma
            Console.WriteLine($"Student 1: {student.Name} {student.Surname}, Age: {student.Age}, Birth Date: {student.BirthDate:dd MMMM yyyy}");
            Console.WriteLine($"Student 2: {student2.Name} {student2.Surname}, Age: {student2.Age}, Birth Date: {student2.BirthDate:dd MMMM yyyy}");

            Console.WriteLine($"Teacher 1: {teacher.Name} {teacher.Surname}, Age: {teacher.Age}, Birth Date: {teacher.BirthDate:dd MMMM yyyy}");
            Console.WriteLine($"Teacher 2: {teacher2.Name} {teacher2.Surname}, Age: {teacher2.Age}, Birth Date: {teacher2.BirthDate:dd MMMM yyyy}");
        }
    }
}
