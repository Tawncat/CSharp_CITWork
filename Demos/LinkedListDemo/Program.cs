//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 03/11/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Demo 1 of Doubly-Linked Lists. (Console)
//******************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<int> data = new LinkedList<int>();

            int[] myArray = { 76, 27, 68, 34, 12 };

            foreach (int num in myArray)
            {
                data.AddFirst(num);
            }

            Console.WriteLine("\nForward Pass");
            for (LinkedListNode<int> node = data.First; node != null; node = node.Next)
            {
                int num = node.Value;
                Console.WriteLine(num);
            }

            Console.WriteLine("\nBackward Pass");
            for (LinkedListNode<int> node = data.Last; node != null; node = node.Previous)
            {
                int num = node.Value;
                Console.WriteLine(num);
            }
        }
    }
}
