namespace KruskalAlgorithm
{
    public partial class Form1 : Form
    {
        Graph graph;

        Bitmap bmpOriginal;
        Bitmap bmpGraph;


        public Form1()
        {
            InitializeComponent();
            bmpOriginal = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bmpOriginal;

            bmpGraph = new Bitmap(pictureBox.Width, pictureBox.Height);
            

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
                drawGraph();
                fillTreeView();
                fillComboBoxOrigin();
            }
        }

        private void comboBoxOriginVertex_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboBoxDestination();
        }




        // ************* Show Grahp Methods *************
        void drawGraph()
        {
            drawVertices();
            drawIds();

            pictureBox.Image = bmpGraph;
            pictureBox.Refresh();
        }

        void drawVertices()
        {
            Graphics g = Graphics.FromImage(bmpGraph);
            Brush b = new SolidBrush(Color.Black);

            foreach (Vertex vertex in graph.Vertices)
                g.FillEllipse(b, vertex.Position.X - 25, vertex.Position.Y - 25, 50, 50);
        }

        void drawIds()
        {
            Graphics g = Graphics.FromImage(bmpGraph);
            Font f = new Font("Cascadia Code", 10);
            SolidBrush b = new SolidBrush(Color.Red);
            
            foreach(Vertex vertex in graph.Vertices)
                g.DrawString(vertex.Id.ToString(), f, b, vertex.Position);
        }

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
                if(v != (Vertex)comboBoxOriginVertex.SelectedItem)
                    comboBoxDestinationVertex.Items.Add(v);
        }

    }
}
