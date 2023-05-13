using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_S_Kraskalom
{
    internal class Edge
    {
        public int Source { get; }
        public int Destination { get; }
        public int Weight { get; }

        public Edge(int source, int destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
}