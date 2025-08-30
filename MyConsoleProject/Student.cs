using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleProject
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }

        public Student(string name, int age, string gender, string height)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
        }

    
    //class Program;
    
        static void Main()
        {
            Student student1 = new Student("Precious", 17, "Female", "5'6\"");
            Student student2 = new Student("Olalekan", 18, "Male", "5'10\"");

            Console.WriteLine("Student 1:");
            Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Gender: {student1.Gender}, Height: {student1.Height}");

            Console.WriteLine("\nStudent 2:");
            Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Gender: {student2.Gender}, Height: {student2.Height}");
        }
    }
}
