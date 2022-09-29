using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalAlgorithm
{
    internal class Edge
    {
        Vertex origin;
        Vertex destination;
        float weight;


        public Edge(Vertex origin, Vertex destination)
        {
            this.origin = origin;
            this.destination = destination;
            this.weight = calculateWeight(origin, destination);
        }


        public Vertex Origin
        {
            get { return origin; }
        }

        public Vertex Destination
        {
            get { return destination; }
        }

        public float Weight
        {
            get { return weight; }
        }

        float calculateWeight(Vertex origin, Vertex destination)
        {
            return (float)Math.Sqrt(Math.Pow((destination.Position.X - origin.Position.X), 2) + Math.Pow((destination.Position.Y - origin.Position.Y), 2));
        }

    }
}
