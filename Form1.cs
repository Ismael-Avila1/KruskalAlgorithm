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

        private void buttonCreateVertices_Click(object sender, EventArgs e)
        {
            labelRemainingVertices.Text = "Selecciona d�nde quieres poner los " + numericUpDownVerticesNumber.Value + " v�rtices en el lienzo de arriba!!";
            labelRemainingVertices.ForeColor = Color.Black;
            pictureBox.Enabled = true;
            pictureBox.BackColor = Color.White;

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(graph.VertexCount == (int)numericUpDownVerticesNumber.Value) {
                labelRemainingVertices.Text = "Ya no quedan v�rtices por agregar";
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

            if(graph.VertexCount == (int)numericUpDownVerticesNumber.Value)
                drawGraph();
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



    }
}
