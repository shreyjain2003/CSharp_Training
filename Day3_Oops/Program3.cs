using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Capgemini_Training
{
        // ================= Base Class =================
        class Student
        {
            public int RollNo;
            public string Name;
            public int Age;

            public Student(int roll, string name, int age)
            {
                RollNo = roll;
                Name = name;
                Age = age;
            }
        
            public virtual void Display()
            {
                Console.WriteLine($"RollNo: {RollNo}, Name: {Name}, Age: {Age}");
            }
        }

        // ================= High School =================
        class HighSchoolStudent : Student
        {
            public string Board;

            public HighSchoolStudent(int r, string n, int a, string board)
                : base(r, n, a)
            {
                Board = board;
            }

            public override void Display()
            {
                Console.WriteLine($"[HighSchool] {RollNo}, {Name}, {Age}, Board: {Board}");
            }
        }

        // ================= UG =================
        class UGStudent : Student
        {
            public string Degree;

            public UGStudent(int r, string n, int a, string degree)
                : base(r, n, a)
            {
                Degree = degree;
            }

            public override void Display()
            {
                Console.WriteLine($"[UG] {RollNo}, {Name}, {Age}, Degree: {Degree}");
            }
        }

        // ================= PG =================
        class PGStudent : Student
        {
            public string Specialization;

            public PGStudent(int r, string n, int a, string spec)
                : base(r, n, a)
            {
                Specialization = spec;
            }

            public override void Display()
            {
                Console.WriteLine($"[PG] {RollNo}, {Name}, {Age}, Specialization: {Specialization}");
            }
        }

        // ================= Program =================
        class Program3
        {
            static void Main()
            {
                List<Student> students = new List<Student>()
            {
                new HighSchoolStudent(1, "Ravi", 16, "CBSE"),
                new HighSchoolStudent(2, "Aman", 15, "ICSE"),
                new UGStudent(3, "Anjali", 20, "B.Tech"),
                new UGStudent(4, "Neha", 21, "B.Sc"),
                new PGStudent(5, "Shreyansh", 23, "Data Science"),
                new PGStudent(6, "Rahul", 24, "Finance")
            };

                // 1️⃣ Display ALL students
                DisplayAllStudents(students);

                // 2️⃣ Display division-wise
                DisplayByDivision<HighSchoolStudent>("High School Students", students);
                DisplayByDivision<UGStudent>("UG Students", students);
                DisplayByDivision<PGStudent>("PG Students", students);

                Console.ReadLine();
            }

            // ============ Display ALL ============
            static void DisplayAllStudents(List<Student> students)
            {
                Console.WriteLine("\n==== ALL STUDENTS ====");
                foreach (Student s in students)
                    s.Display();
            }

            // ============ Display by Division ============
            static void DisplayByDivision<T>(string title, List<Student> students) where T : Student
            {
                Console.WriteLine($"\n==== {title} ====");
                foreach (Student s in students)
                {
                    if (s is T)
                        s.Display();
                }
            }
        }
    }
