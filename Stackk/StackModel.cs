using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StackModel             //Added a new .cs file as suggested
    {
        private int _currentIndex = -1;   //Assigned access modifiers to specify proper scope(acccess) + Changed the names of the private variables as per the naming standards
                                          //private object _obj;              Got rid of the '_obj' variables as it was unnecessary here
        private List<object> _stackList = new List<object>();        //Changed the casing.

        public void Push(object obj)

        {
            if (obj != null)
            {
                _currentIndex++;
                _stackList.Add(obj);
            }
            else
            {
                Console.WriteLine("Object is null");
            }
        }

        public object Pop()
        {
            if (_currentIndex == -1)     //Changed if statement so that we check if the list is empty in the first place...before assigning anything
            {
                Console.WriteLine("Stack is Empty, nothing to pop.");
                return null;
            }
            else
            {
                object obj = _stackList[_currentIndex];
                _stackList.RemoveAt(_currentIndex);     //Tried using 'RemoveAt' instead of 'Remove'
                _currentIndex--;
                return obj;
            }
        }

        public void Clear()
        {
            _stackList.Clear();
        }

        public void DisplayStack()      //Implemented DisplayStack() using a 'for each' loop instead of a 'for' loop
        {
            Console.Write("Current Stack: [");
            foreach (object obj in _stackList)
            {
                Console.Write($" {obj} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}