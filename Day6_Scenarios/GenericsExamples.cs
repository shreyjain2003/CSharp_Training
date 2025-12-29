using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day6_Scenarios
{
    public class GenericsExamples
    {
        public void Sample()
        {
            List<int> myList = new List<int>();
            myList.Add(10);
            // myList.Add("Hello"); // This will cause a compile-time error
            myList.Add(25);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello World");
            myStack.Push("Generics in C#");
            myStack.Push("Capgemini");
            if (myStack.Count > 0)
            {
                string val = myStack.Pop();
                Console.WriteLine(val);
            }
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(1.1);
            queue.Enqueue(2.2);
            queue.Enqueue(3.3);
            double dequeuedValue = queue.Dequeue();
            Console.WriteLine(dequeuedValue);
        }
    }
}