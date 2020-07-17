using System;
using System.Collections.Generic;

namespace Linked_List_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i.ToString());
            }

            stack.DisplayStack();

            Console.WriteLine("----------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }

            stack.DisplayStack();


            //stack.Push("hello");

            //Console.WriteLine(stack.Count);

            //stack.Peek();

            //stack.Push("world");

            //stack.Peek();

            //stack.DisplayStack();

            //stack.Pop();

            //Console.WriteLine(stack.Count);
        }
    }
}
