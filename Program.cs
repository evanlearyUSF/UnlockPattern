using System;
using System.Collections.Generic;


namespace Kolman_Unlock_Pattern_II
{
    class Graph
    {
        private int V; // No. of vertices

        // Array of lists for
        // Adjacency List Representation
        private List<int>[] adj;

        // Constructor
        Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Function to Add an edge into the graph
        void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list.
        }

        // A function used by DFS
        void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited
            // and print it
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices
            // adjacent to this vertex
            List<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        // The function to do DFS traversal.
        // It uses recursive DFSUtil()
        void DFS(int v)
        {
            // Mark all the vertices as not visited
            // (set as false by default in c#)
            bool[] visited = new bool[V];

            // Call the recursive helper function
            // to print DFS traversal
            DFSUtil(v, visited);
        }

        // Driver Code

        public class Program
        {
            static void Main(string[] args)
            {
                Graph graph = new Graph(9);
                graph.AddEdge(1, 4);
                graph.AddEdge(1, 5);
                graph.AddEdge(1, 6);
                graph.AddEdge(1, 8);
                graph.AddEdge(2, 3);
                graph.AddEdge(2, 4);
                graph.AddEdge(2, 5);
                graph.AddEdge(2, 6);
                graph.AddEdge(2, 7);
                graph.AddEdge(2, 9);
                graph.AddEdge(3, 4);
                graph.AddEdge(3, 5);
                graph.AddEdge(3, 6);
                graph.AddEdge(3, 8);
                graph.AddEdge(4, 5);
                graph.AddEdge(4, 7);
                graph.AddEdge(4, 8);
                graph.AddEdge(4, 9);
                graph.AddEdge(5, 6);
                graph.AddEdge(5, 7);
                graph.AddEdge(5, 8);
                graph.AddEdge(5, 9);
                graph.AddEdge(6, 7);
                graph.AddEdge(6, 8);
                graph.AddEdge(6, 9);
                graph.AddEdge(7, 8);
                graph.AddEdge(8, 9);

            }
        }
    }

}
