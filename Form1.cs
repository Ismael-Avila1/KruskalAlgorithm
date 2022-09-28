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
            bmpOriginal = new Bitmap(pictureBox.Width, pictureBox.Height);
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
            pictureBox.BackColor = Color.White;

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
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
                fillComboBoxOrigin();
            }
        }

        private void comboBoxOriginVertex_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboBoxDestination();
        }

        private void buttonCreateEdge_Click(object sender, EventArgs e)
        {
            Vertex v_o = (Vertex)comboBoxOriginVertex.SelectedItem;
            Vertex v_d = (Vertex)comboBoxDestinationVertex.SelectedItem;

            if(v_o == null || v_d == null) {
                MessageBox.Show("Debes seleccionar de Origen y Destino", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            v_o.addEdge(v_o, v_d);
            v_d.addEdge(v_d, v_o);

            fillTreeView();
            drawGraph(bmpGraph);
            fillComboBoxOrigin();
            comboBoxDestinationVertex.Items.Clear();

            // validar si se añadio por lo menos una arista pada cada vertice (si el grafo ya es conexo)
            buttonCreateMST.Enabled = true;
        }

        private void buttonCreateMST_Click(object sender, EventArgs e)
        {
            drawKruskal(graph.kruskal(), bmpKruskal);
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


        
        // ************* ComboBoxes *************
        void fillComboBoxOrigin()
        {
            comboBoxOriginVertex.Items.Clear();

            foreach(Vertex v in graph.Vertices)
                if(v.Edges.Count < graph.VertexCount)
                    comboBoxOriginVertex.Items.Add(v);
        }

        void fillComboBoxDestination()
        {
            comboBoxDestinationVertex.Items.Clear();

            foreach(Vertex v in graph.Vertices)
                if(v != (Vertex)comboBoxOriginVertex.SelectedItem && !v.existEdge((Vertex)comboBoxOriginVertex.SelectedItem))
                    comboBoxDestinationVertex.Items.Add(v);
        }

    }
}
