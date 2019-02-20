using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class Graph
    {
        public Hashtable NameToIndex;
        public Hashtable IndexToName;
        public List<BinarySearchTreeNode> AdjacencyList;

        public void CreateVerticesTables(List<string> vertices)
        {
            NameToIndex = new Hashtable();
            IndexToName = new Hashtable();
            int index = 0;

            foreach (var vertex in vertices)
            {
                NameToIndex.Add(vertex, index);
                IndexToName.Add(index, vertex);
                index++;
            }
        }

        public List<List<int>> ConvertEdgesToInts(List<List<string>> edges)
        {
            List<List<int>> IntEdges = new List<List<int>>();

            foreach (var item in edges)
            {
                IntEdges.Add(new List<int>() { (int)NameToIndex[item[0]], (int)NameToIndex[item[1]] });
            }
            return IntEdges;
        }

        public void CreateAdjacencyList(List<List<string>> edges)
        {
            AdjacencyList = new List<BinarySearchTreeNode>();
            var groupedEdges = ConvertEdgesToInts(edges).GroupBy(q => q[0]);
            foreach (var vertex in groupedEdges.SelectMany(q=>q))
            {
                var tree = new BinarySearchTree();
                foreach (var item in vertex)
                {
                    tree.Insert(item);
                }
                AdjacencyList.Add(tree.root);
            }
            
        }
    }
}
