using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalAlgorithm
{
    internal class Graph
    {
        List<Vertex> vertices;

        public Graph()
        {
            vertices = new List<Vertex>();
        }

       public void addVertex(int x, int y)
        {
            vertices.Add(new Vertex(vertices.Count+1, new Point(x, y)));
        }

        public int VertexCount
        {
            get { return vertices.Count; }
        }

        public List<Vertex> Vertices
        {
            get { return vertices; }
        }

    }
}
