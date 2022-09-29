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



        // ************* Kruskal *************
        public List<Edge> kruskal()
        {
            List<Edge> candidates = getCandidates();
            List<Edge> promising = new List<Edge>();

            Edge e_i;
            int index1, index2;

            int[,] CC = ccInitialize();

            while(candidates.Count != 0) {
                e_i = selection(candidates);

                index1 = findInCC(CC, e_i.Origin);
                index2 = findInCC(CC, e_i.Destination);

                if(index1 != index2) {
                    combineCC(CC, index1, index2);
                    promising.Add(e_i);
                }
            }

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

        Edge selection(List<Edge> candidates)
        {
            Edge candidate; 
            int minorIndex = 0;

            for(int i=0; i<candidates.Count; i++)
                if(candidates[i].Weight < candidates[minorIndex].Weight)
                    minorIndex = i;
            
            candidate = candidates[minorIndex];
            candidates.RemoveAt(minorIndex);
            return candidate;
        }

        int findInCC(int[,] CC, Vertex v_d)
        {
            for (int i = 0; i < VertexCount; i++)
                for (int j = 0; j < VertexCount; j++)
                    if (CC[i, j] == v_d.Id)
                        return i;
            return -1;
        }

        void combineCC(int[,] CC, int index1, int index2)
        {
            for(int i=0; i<VertexCount; i++)
                if(CC[index2, i] != -1) {
                    CC[index1, i] = CC[index2, i];
                    CC[index2, i] = -1;
                }
        }


    }
}
