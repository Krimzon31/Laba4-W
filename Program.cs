using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba_4
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public string first_name;
            public string last_name;
            public string groupNumber;
            public int[] estimates;

            public Student(string name = "Underfined", string first_name = "Underfined", string last_name = "Underfined", string groupNumber = "Underfined", int[] estimates = null)
            {
                this.name = name;
                this.first_name = first_name;
                this.last_name = last_name;
                this.groupNumber = groupNumber;
                this.estimates = estimates;
            }


        }
        
        static void Main(string[] args)
        {
            Student[] students = { 
                new Student("Edvard", "Geen", "Bobich", "20rt45", new int [5]{3, 4, 5, 5, 2}),
                new Student("Klaus", "Yamino", "Eterovich", "20rt45", new int [5]{5, 4, 5, 5, 3}),
                new Student("Jorno", "Jovano", "Diovich", "20rt45", new int [5]{3, 4, 5, 5, 2}),
                new Student("Dio", "Brando", "Geniusovich", "20rt45", new int [5]{3, 4, 5, 5, 2}),
                new Student("Jonatan", "Jostar", "Josefovich", "20rt45", new int [5]{3, 4, 5, 5, 2}),
                new Student("Jotaro", "Kudjo", "Sagavich", "20rt45", new int [5]{3, 4, 5, 5, 2})};

            Array.Sort(students, (a, b) => a.estimates.Average().CompareTo(b.estimates.Average()));

            foreach (Student student in students)
            {
                Console.WriteLine(String.Format("ФИО: {0} {1} {2}, Номер группы: {3}", student.name, student.first_name, student.last_name, student.groupNumber));
            }
            Console.ReadLine();
        }

    }
}

