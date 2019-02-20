using DataStructures.Interfaces;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class SingleLinkedList<T>
    {
        public SingleLinkedListNode<T> head;

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
            var newNode = new SingleLinkedListNode<T>(newData);
            if (head==null)
            {
                head = newNode;
                return;
            }
            var temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void InsertingAtTheBeginning(T newData)
        {
            var newNode = new SingleLinkedListNode<T>(newData);
            if (head == null)
            {
                head = newNode;
                return;
            }
            var tempHead = newNode;
            tempHead.Next = head;
            head = newNode;
        }

        public void InsertNodeNthPosition(T newData, T key)
        {
            var temp = head;
            while(!EqualityComparer<T>.Default.Equals(temp.Value, key))
            {
                temp = temp.Next;
            }
            var newNode = new SingleLinkedListNode<T>(newData);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void DeleteNodeOnNthPosition(T key)
        {
            if (EqualityComparer<T>.Default.Equals(head.Value, key))
            {
                head = head.Next;
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
                temp.Next = nodeToDelete.Next;
                nodeToDelete = null;
            }
        }

        public void ReverseLinkedList()
        {
            SingleLinkedListNode<T> temp = head;
            SingleLinkedListNode<T> previous = null;
            SingleLinkedListNode<T> current = head;

            while (temp != null)
            {
                current = temp;
                temp = temp.Next;
                head = current;
                head.Next = previous;
                previous = current;
            }
            return;
        }

        public void RecursivePrint(SingleLinkedListNode<T> head)
        {
            var temp = head;
            if (temp!=null)
            {
                Console.WriteLine(temp.Value);
                RecursivePrint(temp.Next);
            }
            return;
        }

        public void RecursiveReverse(SingleLinkedListNode<T> current, SingleLinkedListNode<T> previous)
        {
            var temp = current;
            if (temp!=null)
            {
                temp = temp.Next;
                head = current;
                head.Next = previous;
                previous = head;
                RecursiveReverse(temp, previous);
            }
        }

        public void RecursiveReversePrint(SingleLinkedListNode<T> current)
        {
            if (current == null)
            {
                Console.WriteLine("Nothing to print");
                return;
            }
            var temp = current;
            if (temp.Next != null)
            {
                temp = temp.Next;
                RecursiveReversePrint(temp);
                Console.WriteLine(temp.Value);
            }
            Console.WriteLine(current.Value);
        }
    }

    public class SingleLinkedListNode<T>
    {
        public T Value;
        public SingleLinkedListNode<T> Next;
        public SingleLinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
