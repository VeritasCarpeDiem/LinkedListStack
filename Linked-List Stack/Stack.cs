using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Linked_List_Stack
{
    // node containing strings
    // stack of strings
    public class Node<T>
    {

        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Prev { get; set; }
        public Node(T val)
        {
            this.Value = val;
        }

    }

    public class Stack<T> //LIFO: Last In, First Out
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }
        public Stack()
        {
            Count = 0;
            Head = null;
        }
        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void AddLast(T Value)
        {
            if (Head == null)
            {
                Head = new Node<T>(Value);
                Tail = Head;
            }
            else
            {
                Node<T> newNode = new Node<T>(Value);

                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
            }


            //if (IsEmpty())
            //{
            //    Head = new Node(Value);
            //    Tail = Head;
            //}
            //else
            //{
            //    Tail.Next = new Node(Value);
            //    Tail.Prev = Tail;
            //    Tail = Tail.Next;
                 
            //}
            Count++;
        }

        public void Push(T Value)
        {
            AddLast(Value);
        }

        void RemoveLast()
        {
           
            if (!IsEmpty())
            {
                if (Tail == null)//case for 1 item
                {
                   
                    Head = Tail;
                    
                   
                }
                
                else
                {
                    Tail = Tail.Prev;
                   // Tail.Next = null;
                }
                Count--;
            }
            
        }
        public void Pop()
        {
            RemoveLast();

        }
        public T Peek()
        {
            return Tail.Value;

        }

        public void DisplayStack()
        {
            Node<T> current = Head;
            for (int i = 0; i < Count; i++)
            {
                Console.Write(current.Value + ",");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
