using System;
namespace hw1
{
    [Serializable]
    public class Student

    {  
        public string name;
        public string surname;
        public int age;
        public string id;
        public string faculty;
           

            public Student() { }

            public Student(string name, string surname, int age, string id, string faculty)
            {
            
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.id = id;
            this.faculty = faculty;

            }

            public override string ToString()
            {
            return "Name: " + name + "\nSurname: " + surname + "\nAge: " + age + "\nStudent ID: " + id + "\nFaculty: " + faculty;
            }


    }
}
