namespace KruskalAlgorithm
{
    public partial class Form1 : Form
    {
        Graph graph;

        Bitmap bmpOriginal;
        Bitmap bmpGraph;
        Bitmap bmpKruskal;

        public Form1()
        {
            InitializeComponent();
            bmpOriginal = resetBmp();
            pictureBox.Image = bmpOriginal;

            bmpGraph = new Bitmap(pictureBox.Width, pictureBox.Height);
            bmpKruskal = new Bitmap(pictureBox.Width, pictureBox.Height);
            
            graph = new Graph();
        }


        // ************* Events *************
        private void buttonCreateVertices_Click(object sender, EventArgs e)
        {
            labelRemainingVertices.Text = "Selecciona dónde quieres poner los " + numericUpDownVerticesNumber.Value + " vértices en el lienzo de arriba!!";
            labelRemainingVertices.ForeColor = Color.Black;
            pictureBox.Enabled = true;

            groupBox1.Enabled = false;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(graph.VertexCount == (int)numericUpDownVerticesNumber.Value) {
                labelRemainingVertices.Text = "Ya no quedan vértices por agregar";
                labelRemainingVertices.ForeColor = Color.DarkRed;
                return;
            }

            graph.addVertex(e.X, e.Y);

            Graphics g = Graphics.FromImage(bmpOriginal);
            Brush b = new SolidBrush(Color.Black);
            g.FillEllipse(b, e.X - 25, e.Y - 25, 50, 50);

            pictureBox.Refresh();
            labelRemainingVertices.Text = "Quedan " + (numericUpDownVerticesNumber.Value - graph.VertexCount) + " por agregar";
            labelRemainingVertices.ForeColor = Color.DarkGreen;

            if(graph.VertexCount == (int)numericUpDownVerticesNumber.Value) {
                drawGraph(bmpGraph);
                fillTreeView();

                createEdges();
                drawGraph(bmpGraph);
                fillTreeView();
                showListViewGraph();

                buttonCreateMST.Enabled = true;
            }
        }


        private void buttonCreateMST_Click(object sender, EventArgs e)
        {
            List<Edge> mst = graph.kruskal();
            drawKruskal(mst, bmpKruskal);
            showListViewKruskal(mst);
        }


        // ************* reset Bitmap *************
        Bitmap resetBmp()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics grp = Graphics.FromImage(bmp))
            {
                grp.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
            }

            return bmp;
        }



        // ************* Show Grahp Methods *************
        void drawGraph(Bitmap bmp)
        {
            drawEdges(bmp);
            drawVertices(bmp);
            drawIds(bmp);

            pictureBox.Image = bmp;
            pictureBox.Refresh();
        }

        void drawVertices(Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            Brush b = new SolidBrush(Color.Black);

            foreach (Vertex vertex in graph.Vertices)
                g.FillEllipse(b, vertex.Position.X - 25, vertex.Position.Y - 25, 50, 50);
        }

        void drawIds(Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            Font f = new Font("Cascadia Code", 10);
            SolidBrush b = new SolidBrush(Color.Red);
            
            foreach(Vertex vertex in graph.Vertices)
                g.DrawString(vertex.Id.ToString(), f, b, vertex.Position);
        }

        void drawEdges(Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.BlueViolet);

            foreach(Vertex v in graph.Vertices)
                for (int i = 0; i < v.Edges.Count; i++)
                    g.DrawLine(p, v.Position, v.getDestinationAt(i).Position);
        }

        void drawKruskal(List<Edge> mst, Bitmap bmp)
        {
            drawEdges(bmp);

            Graphics g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.Green, 4);

            foreach (Edge edge in mst)
                g.DrawLine(p, edge.Origin.Position, edge.Destination.Position);

            drawVertices(bmp);
            drawIds(bmp);

            pictureBox.Image = bmp;
            pictureBox.Refresh();
        }



        // ************* TreeView *************
        void fillTreeView()
        {
            treeView.Nodes.Clear();

            foreach(Vertex vertex in graph.Vertices) {
                TreeNode node = new TreeNode(vertex.ToString());

                for(int i=0; i<vertex.Edges.Count; i++) {
                    TreeNode son = new TreeNode(vertex.getDestinationAt(i).ToString());
                    node.Nodes.Add(son);
                }
                treeView.Nodes.Add(node);
            }
        }



        // ************* ListViews *************
        void showListViewGraph()
        {
            foreach(Vertex v_o in graph.Vertices)
                foreach(Edge e in v_o.Edges)
                    listViewGraph.Items.Add(new ListViewItem(new String[] {e.Origin.Id.ToString(), e.Destination.Id.ToString(), e.Weight.ToString()}));
        }

        void showListViewKruskal(List<Edge> mst)
        {
            foreach(Edge e in mst)                
                listViewKruskal.Items.Add(new ListViewItem(new String[] { e.Origin.Id.ToString(), e.Destination.Id.ToString()}));
        }



        // ************* CheckEdges *************
        List<Point> getPath(Vertex v_o, Vertex v_d)
        {
            float x_0, y_0;
            float x_f, y_f;

            int x_k, y_k; // estas variables se usan para iterar

            float m, b;

            int inc = 1;

            List<Point> path = new List<Point>();

            x_0 = v_o.Position.X;
            y_0 = v_o.Position.Y;

            x_f = v_d.Position.X;
            y_f = v_d.Position.Y;

            if(x_f - x_0 == 0) { // Si es una linea recta vertical
                if(y_0 > y_f) // Si el primer click se dio abajo y el segundo arriba
                    inc = -1;

                for(y_k = (int)y_0; y_k != y_f; y_k += inc)
                    path.Add(new Point((int)Math.Round(x_0), y_k));
            }
            else {
                m = (y_f - y_0) / (x_f - x_0);  // m representa la inclnacion de la pendiente en la ecuacion lineal
                b = y_f - m * x_f;              // b es el termino constante de la ecuacion linea. represenra el desplazamiento

                if(m > -1 && m < 1) {
                    if(x_0 > x_f) // Si el primer click se dio a la derecha y el segundo a la izquerda
                        inc = -1;

                    for(x_k = (int)x_0; x_k != x_f; x_k += inc) {
                        y_k = (int)(m * x_k + b);
                        path.Add(new Point(x_k, y_k));
                    }
                }
                else {
                    if(y_0 > y_f) // Si se dio el primer click abajo y el segundo arriba
                        inc = -1;

                    for(y_k = (int)y_0; y_k != y_f; y_k += inc) {
                        x_k = (int)((1 / m) * (y_k - b));
                        path.Add(new Point(x_k, y_k));
                    }
                }
            }

            return path;
        }

        bool isWhite(Color color)
        {
            if (color.R == 255)
                if (color.G == 255)
                    if (color.B == 255)
                        return true;
            return false;
        }

        bool isBlack(Color color)
        {
            if (color.R == 0)
                if (color.G == 0)
                    if (color.B == 0)
                        return true;
            return false;
        }

        bool existEdge(List<Point> path, Bitmap bmp)
        {
            int i = 0;

            while(isBlack(bmp.GetPixel(path[i].X, path[i].Y)))     // mientras estemos dentro del circulo negro de origen
                i++;
            // ya salimos del circulo de origen


            while(isWhite(bmp.GetPixel(path[i].X, path[i].Y))) { // mientras no encontremos algo diferente de blanco
                if(!isWhite(bmp.GetPixel(path[i].X, path[i].Y)) && !isBlack(bmp.GetPixel(path[i].X, path[i].Y))) // color diferente de negro y blanco
                    return false; // Se encontro con un obstaculo
                i++;
            } // llegamos a un circulo


            while(i < path.Count - 1) {
                if (isWhite(bmp.GetPixel(path[i].X, path[i].Y))) // llegamos a un pixel blanco, o sea, no era el ciruclo destino y i está afuera del circulo
                    return false;
                i++;
            }

            return true;
        }

        void createEdges()
        {
            foreach(Vertex v_o in graph.Vertices)
                foreach(Vertex v_d in graph.Vertices)
                    if(v_o != v_d)
                        if(existEdge(getPath(v_o, v_d), bmpOriginal))
                            v_o.addEdge(v_o, v_d);
        }



    }
}
