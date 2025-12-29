using System;

namespace Capgemini_Training
{
    /// <summary>
    /// Student Definition
    /// </summary>
    public class Student1
    {
        //int Add(int a,int b)
        //{
        //    return a + b;
        //}
        //static void Main(string[] args)
        //{
        //    Class_Practice res=new Class_Practice();
        //    Console.WriteLine("Enter two numbers to add: ");
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    int result= res.Add(a, b);
        //    Console.WriteLine("Result: " + result);
        //}
        //#region Declaration
        //public int Id;
        //public string Name;
        //#endregion

        //#region Constructor
        //public Student()
        //{
        //    Id = 0;
        //    Name = string.Empty;
        //}
        //#endregion

        //#region Member Function
        //public string GetDetails()
        //{
        //    return "Id" + Id + "Name" + Name;
        //}
        //#endregion


        int roll;
        string name;

        // Parameterized Constructor
        public Student1(int r, string n)
        {
            roll = r;
            name = n;
        }

        public void Display()
        {
            Console.WriteLine("Roll No: " + roll);
            Console.WriteLine("Name: " + name);
        }
    }
}

