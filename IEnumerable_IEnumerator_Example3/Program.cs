using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_IEnumerator_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 15, 21, 100, 4, 25 };

            Stack<int> newStack = new Stack<int>();
            newStack.Push(12);
            newStack.Push(45);
            newStack.Push(32);
            newStack.Push(1);
            newStack.Push(78);
            newStack.Push(100);

            int[] newArray = new int[] { 1, 2, 3, 4, 5, 6, };

            Console.WriteLine("Sum from List<>");
            CollectionSum(list);
            Console.WriteLine("\n");

            Console.WriteLine("Sum from Stack<>");
            CollectionSum(newStack);
            Console.WriteLine("\n");

            Console.WriteLine("Sum from []");
            CollectionSum(newArray);
            Console.WriteLine("\n");

        }

        
        


        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int i in anyCollection)
            {
                sum+=i;
                
            }
            Console.WriteLine("sum = {0}", sum);
        }
    }
}
