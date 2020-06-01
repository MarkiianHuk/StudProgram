using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentProgram
{
    class Group
    {
        public string Name;
        public List<Student> students = new List<Student>();
        public double average;
        public Group(string name)
        {
            this.Name = name;
            students.Add(new Student());
        }

        public void Add(Student st)
        {
            students.Add(st);
        }
        public void GetAverage()
        {
            average = students.Average(a => a.mark.Rating);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
