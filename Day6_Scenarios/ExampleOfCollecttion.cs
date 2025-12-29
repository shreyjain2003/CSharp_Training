using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day6_Scenarios
{
    public class ExampleOfCollecttion
    {
        public void Sample()
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add("Hello"); 
            myList.Add(25.5);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push("Hello World");
            myStack.Push(3.14);

            if(myStack.Count>0)
            {
                if(myStack.Pop() is int)
                {
                    int val = (int)myStack.Pop();
                    Console.WriteLine(val);
                }
            }
            myStack.Pop();

            Queue queue=new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Queue");
            queue.Enqueue(3.5);
            queue.Dequeue();

        }
    }
}
