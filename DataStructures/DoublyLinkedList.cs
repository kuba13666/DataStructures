using DataStructures.Interfaces;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> head;

        public void PrintList()
        {
            var temp = head;
            while (temp.Next != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
            Console.WriteLine(temp.Value);
        }

        public void insertingNodeAtTheEnd(T newData)
        {
            var newNode = new DoublyLinkedListNode<T>(newData);
            if (head == null)
            {
                head = newNode;
                return;
            }
            var temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            newNode.Previous = temp;
            temp.Next = newNode;
        }

        public void InsertingAtTheBeginning(T newData)
        {
            var newNode = new DoublyLinkedListNode<T>(newData);
            if (head == null)
            {
                head = newNode;
                return;
            }
            var tempHead = newNode;
            tempHead.Next = head;
            head.Previous = newNode;
            head = newNode;
        }

        public void InsertNodeNthPosition(T newData, T key)
        {
            var temp = head;
            var nextNode = temp.Next;
            while (!EqualityComparer<T>.Default.Equals(temp.Value, key))
            {
                temp = temp.Next;
            }
            var newNode = new DoublyLinkedListNode<T>(newData);
            newNode.Next = temp.Next;
            newNode.Previous = temp;
            temp.Next = newNode;
            nextNode.Previous = newNode;
        }

        public void DeleteNodeOnNthPosition(T key)
        {
            if (EqualityComparer<T>.Default.Equals(head.Value, key))
            {
                head = head.Next;
                head.Previous = null;
            }
            else
            {
                var temp = head;
                try
                {
                    while (!EqualityComparer<T>.Default.Equals(temp.Next.Value, key))
                    {
                        temp = temp.Next;
                    }
                }
                catch
                {
                    Console.WriteLine("Given key not present in the collection");
                    return;
                }

                var nodeToDelete = temp.Next;
                var temp2 = nodeToDelete.Next;
                temp.Next = temp2;
                temp2.Previous = temp;
                nodeToDelete = null;
            }
        }

        public void ReverseLinkedList()
        {
            DoublyLinkedListNode<T> temp = null;
            DoublyLinkedListNode<T> current = head;

            while (temp != null)
            {
                temp = current.Previous;
                current.Previous = current.Next;
                current.Next = temp;
                current = current.Previous;
            }
            return;
        }
    }

    public class DoublyLinkedListNode<T>
    {
        public T Value;
        public DoublyLinkedListNode<T> Next;
        public DoublyLinkedListNode<T> Previous;
        public DoublyLinkedListNode(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
