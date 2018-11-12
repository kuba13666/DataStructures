using DataStructures.Interfaces;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    internal class SingleLinkedList<T>
    {
        internal Node<T> head;
        public void insertingNode(SingleLinkedList<T> linkedList, T newData)
        {
            var newNode = new Node<T>(newData);
            if (linkedList.head==null)
            {
                linkedList.head = newNode;
                return;
            }
            var tail = linkedList.GetLastNode();
            tail.Next = newNode;
        }
        //ti be implemented
        private Node<T> GetLastNode()
        {
            var temp = head;
            while (temp!=null)
            {
                temp = temp.Next;
            }
            return temp;
        }
    }
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
