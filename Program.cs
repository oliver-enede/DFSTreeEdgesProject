﻿namespace DFSTreeEdgesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DirectedGraph g = new DirectedGraph();
            g.InsertVertex("Zero");
            g.InsertVertex("One");
            g.InsertVertex("Two");
            g.InsertVertex("Three");
            g.InsertVertex("Four");
            g.InsertVertex("Five");
            g.InsertVertex("Six");
            g.InsertVertex("Seven");
            g.InsertVertex("Eight");
            g.InsertVertex("Nine");
            g.InsertVertex("Ten");
            g.InsertVertex("Eleven");

            g.InsertEdge("Zero", "One");
            g.InsertEdge("Zero", "Three");
            g.InsertEdge("One", "Two");
            g.InsertEdge("One", "Four");
            g.InsertEdge("One", "Five");
            g.InsertEdge("Two", "Five");
            g.InsertEdge("Two", "Seven");
            g.InsertEdge("Three", "Six");
            g.InsertEdge("Four", "Three");
            g.InsertEdge("Five", "Three");
            g.InsertEdge("Five", "Six");
            g.InsertEdge("Five", "Eight");
            g.InsertEdge("Seven", "Eight");
            g.InsertEdge("Seven", "Ten");
            g.InsertEdge("Eight", "Eleven");
            g.InsertEdge("Nine", "Six");
            g.InsertEdge("Eleven", "Nine");

            g.DfsTreeEdges();

            Console.ReadLine();
        }
    }
}
