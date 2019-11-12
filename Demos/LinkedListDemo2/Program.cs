//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 05/08/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Linked List Demo 2 (Console)
//******************************************************************
using System;
using System.Collections.Generic;

namespace LinkedListDemo2
{
    class Program
    {
        public class LinkedListNode<T>
        {
            //setting up the linked list
            public LinkedList<T> List { get; }
            public LinkedListNode<T> Next { get; }
            public LinkedListNode<T> Previous { get; }
            public T Value { get; set; }
        }
        static void Main(string[] args)
        {
            var tune = new LinkedList<string>();//create the linked list

            tune.AddFirst("do");
            tune.AddLast("so");

            foreach (string s in tune)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            tune.AddAfter(tune.First, "re");//add after do
            tune.AddAfter(tune.First.Next, "mi");//add after re
            tune.AddBefore(tune.Last, "fa");//add before so

            foreach (string s in tune)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            tune.RemoveFirst();//remove do
            tune.RemoveLast();//remove so
            foreach (string s in tune)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }
    }
}
