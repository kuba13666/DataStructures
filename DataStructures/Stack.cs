using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        private StackNode<T> top;
        public void Push(T data)
        {
            var newNode = new StackNode<T>(data);
            if (top == null)
            {
                top = newNode;
                return;
            }
            newNode.Previous = top;
            top = newNode;
        }

        public StackNode<T> Pop()
        {
            if (top == null)
            {
                return null;
            }
            top = top.Previous;
            return top;
        }

        public StackNode<T> Top()
        {
            if (top == null)
            {
                return null;
            }
            return top;
        }

        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }

        public void PrintStack()
        {
            var temp = top;
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Previous;
            }
        }
    }

    public class StackNode<T>
    {
        public T Data;
        public StackNode<T> Previous;
        public StackNode(T data)
        {
            Data = data;
            Previous = null;
        }
    }
}
