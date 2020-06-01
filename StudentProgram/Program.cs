using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace StudentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group("group1");
            group1.Add(new Student("Vasyl", 10, "Math"));
            group1.Add(new Student("Ostap", 20, "Math"));
            group1.Add(new Student("Vasyl", 50, "Math"));           
            Group group2 = new Group("group2");
            group2.Add(new Student("Ostap ", 20, "Math"));
            group2.Add(new Student("Vasyl", 100, "Math"));
            group2.Add(new Student("Vasyl", 200, "Math"));
            Group group3 = new Group("group3");
            group3.Add(new Student("Ostap", 20, "Math"));
            group3.Add(new Student("Vasyl", 40, "Math"));
            group3.Add(new Student("Vasyl", 40, "Math"));
            group1.Add(new Student("Vasyl", 40, "Math"));
            List<Group> groups = new List<Group>();
            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);
            group1.GetAverage();
            group2.GetAverage();
            group3.GetAverage();
            double minrating1 = groups.Min(a => a.average);
            Group minrating1Group = groups.Find(x => x.average == minrating1);
            groups.Remove(minrating1Group);
            double minrating2 = groups.Min(a => a.average);
            Group minrating2Group = groups.Find(x => x.average == minrating2);
            Console.WriteLine("Рейтинг найнижчий у таких двох групах: ");
            Console.WriteLine(minrating1Group.ToString());
            Console.WriteLine(minrating2Group.ToString());
        }
    }
}
