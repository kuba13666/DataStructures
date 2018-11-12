using DataStructures;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dupa = new List<int>();
            var pizda = new List<int>() { 1, 2, 3, 4, 5, 6 };
            dupa.AddRange(pizda);
            dupa.InsertRange(7, pizda);
            Console.WriteLine("Default capacity of a List: " + dupa.Capacity);
            Console.WriteLine("Hello World!");
        }
    }
}
