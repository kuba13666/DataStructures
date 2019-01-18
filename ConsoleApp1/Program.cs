using DataStructures;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinarySearchTree();
            List<int> sortedArray = new List<int>() { 1, 2, 3, 4, 10, 12, 20, 36, 40, 50 };
            var counter = sortedArray.Count;
            for (int i = 0; i < counter; i++)
            {
                tree.Insert(sortedArray[sortedArray.Count / 2]);
                sortedArray.RemoveAt(sortedArray.Count / 2);
            }
            var searchResult = tree.SearchForANode(tree.root, 50);
            var max = tree.Max(tree.root);
            var height = tree.Height(tree.root);
            Console.ReadLine();
        }
    }
}
