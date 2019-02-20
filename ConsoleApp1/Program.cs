using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinarySearchTree();
            var doubly = new SingleLinkedList<int>();
            List<int> sortedArray = new List<int>() { 20, 10, 4, 12, 36, 22, 40, 50, 42, 55 };
            foreach (var item in sortedArray)
            {
                doubly.insertingNodeAtTheEnd(item);
            }
            doubly.PrintList();
            doubly.ReverseLinkedList();
            doubly.PrintList();
            foreach (var item in sortedArray)
            {
                tree.Insert(item);
            }
            var searchResult = tree.SearchForANode(tree.root, 36);
            var inorderSuccessor = tree.InorderSuccessor(tree.root, 12);
            var max = tree.Max(tree.root);
            var height = tree.Height(tree.root, 0, 0);
            tree.TraverseInorder(tree.root);
            tree.Delete(tree.root, 50);
            Console.WriteLine(tree.IsBSTUtil(tree.root, int.MaxValue, int.MinValue));

            var edges = new List<List<string>>();
            edges.Add(new List<string>() { "a", "b" });
            edges.Add(new List<string>() { "a", "c" });
            edges.Add(new List<string>() { "a", "d" });
            edges.Add(new List<string>() { "a", "e" });
            edges.Add(new List<string>() { "a", "f" });
            edges.Add(new List<string>() { "b", "a" });
            edges.Add(new List<string>() { "b", "c" });
            edges.Add(new List<string>() { "b", "d" });
            edges.Add(new List<string>() { "b", "e" });
            var graph = new Graph();
            graph.CreateVerticesTables(new List<string>() { "a", "b", "c", "d", "e", "f", });
            graph.CreateAdjacencyList(edges);
            Console.ReadLine();
        }
    }
}
