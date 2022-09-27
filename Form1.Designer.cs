namespace KruskalAlgorithm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownVerticesNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateVertices = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCreateEdge = new System.Windows.Forms.Button();
            this.comboBoxDestinationVertex = new System.Windows.Forms.ComboBox();
            this.comboBoxOriginVertex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRemainingVertices = new System.Windows.Forms.Label();
            this.buttonCreateMST = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(700, 700);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(718, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algoritmo de Kruskal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecciona la cantidad de vértices del grafo: ";
            // 
            // numericUpDownVerticesNumber
            // 
            this.numericUpDownVerticesNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownVerticesNumber.Location = new System.Drawing.Point(459, 47);
            this.numericUpDownVerticesNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownVerticesNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownVerticesNumber.Name = "numericUpDownVerticesNumber";
            this.numericUpDownVerticesNumber.ReadOnly = true;
            this.numericUpDownVerticesNumber.Size = new System.Drawing.Size(68, 32);
            this.numericUpDownVerticesNumber.TabIndex = 3;
            this.numericUpDownVerticesNumber.UseWaitCursor = true;
            this.numericUpDownVerticesNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonCreateVertices
            // 
            this.buttonCreateVertices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.buttonCreateVertices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateVertices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateVertices.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateVertices.Location = new System.Drawing.Point(10, 115);
            this.buttonCreateVertices.Name = "buttonCreateVertices";
            this.buttonCreateVertices.Size = new System.Drawing.Size(520, 80);
            this.buttonCreateVertices.TabIndex = 4;
            this.buttonCreateVertices.Text = "Añadir Vértices";
            this.buttonCreateVertices.UseVisualStyleBackColor = false;
            this.buttonCreateVertices.Click += new System.EventHandler(this.buttonCreateVertices_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreateVertices);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownVerticesNumber);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(731, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación de Vértices";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCreateEdge);
            this.groupBox2.Controls.Add(this.comboBoxDestinationVertex);
            this.groupBox2.Controls.Add(this.comboBoxOriginVertex);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(731, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 253);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Creación de Aristas";
            // 
            // buttonCreateEdge
            // 
            this.buttonCreateEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.buttonCreateEdge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateEdge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateEdge.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateEdge.Location = new System.Drawing.Point(10, 150);
            this.buttonCreateEdge.Name = "buttonCreateEdge";
            this.buttonCreateEdge.Size = new System.Drawing.Size(520, 80);
            this.buttonCreateEdge.TabIndex = 4;
            this.buttonCreateEdge.Text = "Crear Arista";
            this.buttonCreateEdge.UseVisualStyleBackColor = false;
            // 
            // comboBoxDestinationVertex
            // 
            this.comboBoxDestinationVertex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestinationVertex.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDestinationVertex.FormattingEnabled = true;
            this.comboBoxDestinationVertex.Location = new System.Drawing.Point(324, 101);
            this.comboBoxDestinationVertex.Name = "comboBoxDestinationVertex";
            this.comboBoxDestinationVertex.Size = new System.Drawing.Size(203, 32);
            this.comboBoxDestinationVertex.TabIndex = 3;
            // 
            // comboBoxOriginVertex
            // 
            this.comboBoxOriginVertex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOriginVertex.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOriginVertex.FormattingEnabled = true;
            this.comboBoxOriginVertex.Location = new System.Drawing.Point(324, 41);
            this.comboBoxOriginVertex.Name = "comboBoxOriginVertex";
            this.comboBoxOriginVertex.Size = new System.Drawing.Size(203, 32);
            this.comboBoxOriginVertex.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selecciona el vértice de destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecciona el vértice de origen:";
            // 
            // labelRemainingVertices
            // 
            this.labelRemainingVertices.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemainingVertices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(79)))));
            this.labelRemainingVertices.Location = new System.Drawing.Point(12, 715);
            this.labelRemainingVertices.Name = "labelRemainingVertices";
            this.labelRemainingVertices.Size = new System.Drawing.Size(700, 49);
            this.labelRemainingVertices.TabIndex = 7;
            this.labelRemainingVertices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateMST
            // 
            this.buttonCreateMST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(109)))));
            this.buttonCreateMST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateMST.Enabled = false;
            this.buttonCreateMST.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateMST.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateMST.Location = new System.Drawing.Point(731, 607);
            this.buttonCreateMST.Name = "buttonCreateMST";
            this.buttonCreateMST.Size = new System.Drawing.Size(630, 100);
            this.buttonCreateMST.TabIndex = 8;
            this.buttonCreateMST.Text = "Crear MST con Kruskal";
            this.buttonCreateMST.UseVisualStyleBackColor = false;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.treeView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView.ForeColor = System.Drawing.Color.LavenderBlush;
            this.treeView.Location = new System.Drawing.Point(6, 26);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(272, 436);
            this.treeView.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView);
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(1276, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 485);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualización del Grafo";
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.Enabled = false;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRestart.Location = new System.Drawing.Point(1384, 607);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(176, 100);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "Reestablecer Grafo";
            this.buttonRestart.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1572, 773);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCreateMST);
            this.Controls.Add(this.labelRemainingVertices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo de Kruskal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownVerticesNumber;
        private Button buttonCreateVertices;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonCreateEdge;
        private ComboBox comboBoxDestinationVertex;
        private ComboBox comboBoxOriginVertex;
        private Label label4;
        private Label label3;
        private Label labelRemainingVertices;
        private Button buttonCreateMST;
        private TreeView treeView;
        private GroupBox groupBox3;
        private Button buttonRestart;
    }
}