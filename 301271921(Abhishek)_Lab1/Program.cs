using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


namespace _301271921_Abhishek__Lab1
{
    /* Question 1
       1.1 Use example(s) to illustrate the differences between array and linked list [4 marks]

    */
    public class GenericClass<T> where T : IComparable<T>
    {
        public T[] arrays;

        public GenericClass(int len)
        {
            arrays = new T[len];
        }

        public void AddVal(int i, T a)
        {
            arrays[i] = a;
        }

        public void Display()
        {
            foreach (T t in arrays)
            {
                Console.WriteLine(t);
            }
        }
        public T GetMax()
        {
            T max = arrays[0];
            foreach (T item in arrays)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }

    internal class Program
    {
        //Making a Generic Class with a Constraint :

        static void Main(string[] args)
        {
            /*Difference between Array and Linked List*/
            /*Creating an Array*/
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Displaying the Array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Replacing on third position");
            array[2] = 32;
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }      

            Console.WriteLine("------------------");

            LinkedList<String> list = new LinkedList<String>();
            list.AddLast("Zoya");
            list.AddLast("Shilpa");
            list.AddLast("Rohit");
            list.AddLast("Rohan");
            list.AddLast("Juhi");
            list.AddLast("Zoya");
            Console.WriteLine("Displaying the Linked List");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Removing From list");
            list.RemoveLast();
            list.RemoveLast();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }

            Console.WriteLine("------------------");
            // 1.2 Use example(s) to illustrate the features of stack and queue[4 marks]
            // Creating a queue
            Queue queue = new Queue();

            // Enqueuing elements into the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Dequeuing elements from the queue
            Console.WriteLine("Elements dequeued from the queue:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Stack");

            Stack stack = new Stack();

            // Pushing elements onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("------------------");
            // Popping elements from the stack
            Console.WriteLine("Elements popped from the stack:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }


            Console.WriteLine("------------------");

            // 1.3 Use example to demonstrate what a type constraint is [2 marks]

            // Create an instance of GenericClass with type constraint on IComparable
            GenericClass<int> Abhishek = new GenericClass<int>(10);

            // Adding numbers to the GenericClass
            for (int i = 0; i < 10; i++)
            {
                Abhishek.AddVal(i, i + 1);
            }

            // Displaying the numbers added to GenericClass
            Console.WriteLine("Numbers added to GenericClass:");
            Abhishek.Display();
            //Displaying Max Value

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(Abhishek.GetMax());
        }
    }
}


