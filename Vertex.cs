using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFSTreeEdgesProject
{
    class Vertex
    {
        public string Name { get; set; }
        public int State { get; set; }
        public int Predecessor { get; set; }

        public Vertex(string name)
        {
            Name = name;
        }
    }
}