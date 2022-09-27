﻿using System;
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

        public Vertex() { }

        public Vertex(int id, Point position)
        {
            this.id = id;
            this.position = position;
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

        public int EdgesCount
        {
            get { return edges.Count; }
        }

        public void addEdge(Edge edge)
        {
            edges.Add(edge);
        }


        public override string ToString()
        {
            return "Vertice " + id.ToString();
        }
    }
}
