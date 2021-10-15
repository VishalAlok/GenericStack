using System;
using System.Collections.Generic;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> obj = new Stack<int>();
            obj.Push(5);
            obj.Push(10);
            obj.Push(15);
            //Printing all in LIFO
            foreach (object o in obj)
            {
                Console.WriteLine(o + " ");
            }
            //Printing top
            Console.WriteLine(obj.Peek());
            //Printing top and removing
            Console.WriteLine(obj.Pop());
        }
    }
}
