using DataStructures;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lista = new DataStructures.Stack<string>();
            //for (int i = 0; i < 10; i++)
            //{
            //    lista.Push($"dupa {i}");
            //}
            //lista.PrintStack();
            ////lista.ReverseLinkedList();
            ////Console.WriteLine("reversing");
            ////lista.PrintList();
            ////lista.ReverseLinkedList();
            ////Console.WriteLine("Reversing again");
            ////lista.PrintList();
            var combinations = new List<List<char>>() {
               new List<char> { 'A', 'A' },
               new List<char> { 'A', 'B' },
               new List<char> { 'A', 'C' },
               new List<char> {'B', 'B' },
               new List<char> { 'B', 'C' },
               new List<char> { 'C', 'C' }
            };
            char[] arr = { 'A', 'B', 'C'};
            List<List<char>> mat = new List<List<char>>();
            foreach (var letter in arr)
            {
                foreach (var item in combinations)
                {
                    if (item[0] == letter || item[1]== letter)
                    {
                        mat.Add(item);
                        Console.WriteLine($"{item[0]}, {item[1]}");
                    };
                }
            }
            Console.ReadLine();
        }
    }
}
