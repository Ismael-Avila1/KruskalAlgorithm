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



        // Kruskal
        public List<Edge> kruskal()
        {
            List<Edge> candidates = getCandidates();
            List<Edge> promising = new List<Edge>();

            int[,] CC = ccInitialize();



            return promising;
        }



        List<Edge> getCandidates()
        {
            List<Edge> edges = new List<Edge>();

            foreach(Vertex v in vertices)
                foreach(Edge e in v.Edges)
                    edges.Add(e);
            
            return edges;
        }

        int[,] ccInitialize()
        {
            int[,] cc = new int[VertexCount, VertexCount];

            for(int i=0; i<VertexCount; i++)
                for(int j=0; j<VertexCount; j++)
                    cc[i, j] = -1;
            
            for(int i=0; i<VertexCount; i++)
                cc[i, i] = vertices[i].Id;

            return cc;
        }


    }
}
