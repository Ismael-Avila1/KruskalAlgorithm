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
            
            graph = new Graph();
        }

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
            
            g.FillEllipse(b, e.X - 20, e.Y - 20, 50, 50);

            pictureBox.Refresh();
            labelRemainingVertices.Text = "Quedan " + (numericUpDownVerticesNumber.Value - graph.VertexCount) + " por agregar";
            labelRemainingVertices.ForeColor = Color.DarkGreen;
        }
    }
}
