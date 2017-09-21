using System;

namespace hw2
{
    class Student
    {
        string firstName;
        string lastName;
        double gpa;

        public Student(string firstName, string lastName, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.gpa;
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student s = new Student("Assem", "Urazalimova", 2.3);
            Console.WriteLine(s.ToString());

        }
    }
}
