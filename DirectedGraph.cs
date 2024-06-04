using System;
using System.Collections.Generic;

namespace DFSTreeEdgesProject
{
    class DirectedGraph
    {
        public readonly int MAX_VERTICES = 30;
        int n;
        int e;
        bool[,] adj;
        Vertex[] vertexList;

        /* constants for different states of a vertex */
        private readonly int INITIAL = 0;
        private readonly int VISITED = 1;
        private readonly int NIL = -1;

        public DirectedGraph()
        {
            adj = new bool[MAX_VERTICES, MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }

        public void DfsTreeEdges()
        {
            int v;
            for (v = 0; v < n; v++)
            {
                vertexList[v].State = INITIAL;
                vertexList[v].Predecessor = NIL;
            }

            Console.WriteLine("Enter starting vertex for Depth First Search : ");
            string s = Console.ReadLine();
            DfsTree(GetIndex(s));

            for (v = 0; v < n; v++)
            {
                if (vertexList[v].State == INITIAL)
                    DfsTree(v);
            }

            Console.WriteLine("Tree Edges : ");
            int u;
            for (v = 0; v < n; v++)
            {
                u = vertexList[v].Predecessor;
                if (u != NIL)
                    Console.WriteLine("(" + vertexList[u].Name + ", " + vertexList[v].Name + ")");
            }
        }

        private void DfsTree(int v)
        {
            Stack<int> st = new Stack<int>();
            st.Push(v);

            while (st.Count != 0)
            {
                v = st.Pop();
                if (vertexList[v].State == INITIAL)
                {
                    Console.Write(vertexList[v].Name + " ");
                    vertexList[v].State = VISITED;
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    if (IsAdjacent(v, i) && vertexList[i].State == INITIAL)
                    {
                        st.Push(i);
                        vertexList[i].Predecessor = v;
                    }
                }
            }

            Console.WriteLine();
        }

        public void DfsTraversal()
        {
            for (int v = 0; v < n; v++)
                vertexList[v].State = INITIAL;

            Console.Write("Enter starting vertex for Depth First Search: ");
            string s = Console.ReadLine();
            Dfs(GetIndex(s));
        }

        private void Dfs(int v)
        {
            Stack<int> st = new Stack<int>();
            st.Push(v);

            while (st.Count != 0)
            {
                v = st.Pop();
                if (vertexList[v].State == INITIAL)
                {
                    Console.Write(vertexList[v].Name + " ");
                    vertexList[v].State = VISITED;
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    if (IsAdjacent(v, i) && vertexList[i].State == INITIAL)
                        st.Push(i);
                }
            }

            Console.WriteLine();
        }

        public void DfsTraversal_All()
        {
            int v;
            for (v = 0; v < n; v++)
                vertexList[v].State = INITIAL;

            Console.Write("Enter starting vertex for Depth First Search: ");
            string s = Console.ReadLine();
            Dfs(GetIndex(s));

            for (v = 0; v < n; v++)
            {
                if (vertexList[v].State == INITIAL)
                    Dfs(v);
            }
        }

        public void InsertVertex(string name)
        {
            vertexList[n++] = new Vertex(name);
        }

        private int GetIndex(string s)
        {
            for (int i = 0; i < n; i++)
            {
                if (s.Equals(vertexList[i].Name))
                    return i;
            }

            throw new InvalidOperationException("Invalid Vertex");
        }

        private bool IsAdjacent(int u, int v)
        {
            return adj[u, v];
        }

        /*Insert an edge (s1,s2) */
        public void InsertEdge(string s1, string s2)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (u == v)
                throw new InvalidOperationException("Not a valid edge");

            if (adj[u, v] == true)
                Console.Write("Edge already present");
            else
            {
                adj[u, v] = true;
                e++;
            }
        }
    }
}
