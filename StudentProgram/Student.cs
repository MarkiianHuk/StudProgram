using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProgram
{
    class Student
    {
        public Mark mark = new Mark();
        private string name;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        private int age = 18;
        public int Age
        {
            set
            {
                if (value > 16)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Your age must be more than 16");
                }
            }
            get
            {
                return age;
            }
        }
        public int Course { get; set; }
        public string University { get; set; }
        public Student()
        {

        }

        public Student(string name = "none", int age = 0)
        {
            this.name = name;
            this.age = age;
            this.Course = 0;
            this.University = "none";
        }
        public Student(string name, int age, int course, string university)
        {
            this.name = name;
            this.age = age;
            this.Course = course;
            this.University = university;
        }
        public Student(string name, int rating, string subject)
        {
            this.mark.Rating = rating;
            this.mark.Subject = subject;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine("Student name is:" + name);
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Course " + Course);
            Console.WriteLine("University " + University);
        }
        public override string ToString()
        {
            return "Student name is:" + name
                    + "\nAge is: " + age
                    + "\nCourse " + Course
                    + "\nUniversity " + University;
        }
    }
}
