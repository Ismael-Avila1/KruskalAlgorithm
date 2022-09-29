using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalAlgorithm
{
    internal class Vertex
    {
        int id;
        Point position;
        List<Edge> edges;


        public Vertex(int id, Point position)
        {
            this.id = id;
            this.position = position;
            edges = new List<Edge>();
        }


        public int Id
        {
            get { return id; }
        }

        public Point Position
        {
            get { return position; }
        }

        public List<Edge> Edges
        {
            get { return edges; }
        }

        public void addEdge(Vertex origin, Vertex destination)
        {
            edges.Add(new Edge(origin, destination));
        }

        public Vertex getDestinationAt(int pos)
        {
            return edges[pos].Destination;
        }


        public override string ToString()
        {
            return "Vertice " + id.ToString();
        }
    }
}
