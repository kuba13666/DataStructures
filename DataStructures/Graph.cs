using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Graph
    {
        public List<Edge> EdgeList;
        public List<string> VertexList;
        public Hashtable VertexHashtable;
        public List<List<int>> AdjacencyMatrix;
    }

    public class Edge
    {
        int EndVertex;
        int StartVertex;
        int? Weight;
        public Edge(int endVertex, int startVertex, int? weight = null)
        {
            EndVertex = endVertex;
            StartVertex = startVertex;
            Weight = weight;
        }
    }       
}
