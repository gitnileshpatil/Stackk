using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Output:
                Current Stack: [ 1  2  3 ]
                Object Removed: 3
                Current Stack: [ 1  2 ]
                Object Removed: 2
                Current Stack: [ 1 ]
                Object Removed: 1
                Current Stack: []
             */
            StackModel stack = new StackModel();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.DisplayStack();

            Console.WriteLine("Object Removed: " + stack.Pop());
            stack.DisplayStack();
            Console.WriteLine("Object Removed: " + stack.Pop());
            stack.DisplayStack();
            Console.WriteLine("Object Removed: " + stack.Pop());
            stack.DisplayStack();

            Console.WriteLine();

            stack.Clear();
        }
    }
}