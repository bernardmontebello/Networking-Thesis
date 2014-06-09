using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using System.Diagnostics;

namespace GraphEditor
{
    public partial class FloydWarshallForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public void SaveImate(String filename)
        {
            using (var bmp = new Bitmap(panel.Width, panel.Width))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (choosingSourceVertex)
                    {
                        if (mouseOverVertex != null)
                        {
                            g.DrawMouseOverVertex(mouseOverVertex);
                        }
                    }
                    if (graph.Source != null)
                    {
                        g.DrawSourceVertex(graph.Source);
                    }

                    foreach (Vertex vertex in graph.VertexCollection)
                    {
                        g.DrawDijkstraVertex(vertex, (vertex == u), S.Contains(vertex));
                    }
                    foreach (Edge edge in graph.EdgeCollection)
                    {
                        g.DrawDijkstraEdge(edge, (edge == uv));
                        //g.DrawEdge(edge);
                    }
                    bmp.Save(filename);
                }
            }

        }
        public Graph graph;
        private Boolean choosingSourceVertex = false;
        private Point MouseLocation = Point.Empty;
        private Vertex mouseOverVertex = null;

        ThreadStart ts;
        Thread t;

        public FloydWarshallForm(Boolean isVertical)
        {
            InitializeComponent();
            graph = new Graph(true);
            graph.VertexAdded += new EventHandler<VertexEventArgs>(graph_VertexAdded);
            graph.VertexRemoved += new EventHandler<VertexEventArgs>(graph_VertexRemoved);
            graph.EdgeAdded += new EventHandler<EdgeEventArgs>(graph_EdgeAdded);
            graph.EdgeRemoved += new EventHandler<EdgeEventArgs>(graph_EdgeRemoved);
            panel.Size = isVertical ? new Size(3000, 3000) : new Size(3000, 3000);
        }
        private List<Vertex> Q = new List<Vertex>();
        private List<Vertex> S = new List<Vertex>();
        private Vertex u = null;
        private Edge uv = null;
        private void graph_DijkstraStepPerformed(object o, StepEventArgs e)
        {
            if (e.Comment == "end")
            {
                this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                {
                    kryptonButton1.Enabled = true;
                    kryptonButton2.Enabled = false;
                    kryptonButton3.Enabled = false;
                }));
            }
            if (e.Argument is int[,])
            {
                if (e.Comment == "dinit")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        kryptonRichTextBox1.AppendText("d matrix initialized\n");
                        int[,] d = (int[,])e.Argument;
                        for (int i = 0; i < graph.VertexCollection.Count; i++)
                        {
                            for (int j = 0; j < graph.VertexCollection.Count; j++)
                            {
                                if (d[i, j] == 9999)
                                {
                                    kryptonRichTextBox1.AppendText("\u221E ;");
                                }
                                else
                                {
                                    kryptonRichTextBox1.AppendText(d[i, j].ToString() + " ;");
                                }
                            }
                            kryptonRichTextBox1.AppendText("\n");
                        }
                        kryptonRichTextBox1.AppendText("-----\n");
                    }));
                }
                else if (e.Comment == "predinit")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        kryptonRichTextBox2.AppendText("pred matrix initialized\n");
                        int[,] pred = (int[,])e.Argument;
                        for (int i = 0; i < graph.VertexCollection.Count; i++)
                        {
                            for (int j = 0; j < graph.VertexCollection.Count; j++)
                            {
                                if (pred[i, j] == -1)
                                {
                                    kryptonRichTextBox2.AppendText("\u2205 ;");
                                }
                                else
                                {
                                    kryptonRichTextBox2.AppendText(pred[i, j].ToString() + " ;");
                                }
                            }
                            kryptonRichTextBox2.AppendText("\n");
                        }
                        kryptonRichTextBox2.AppendText("-----\n");
                    }));
                    t.Suspend();
                }
                else if (e.Comment == "d")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        int[,] d = (int[,])e.Argument;
                        for (int i = 0; i < graph.VertexCollection.Count; i++)
                        {
                            for (int j = 0; j < graph.VertexCollection.Count; j++)
                            {
                                if (d[i, j] == 9999)
                                {
                                    kryptonRichTextBox1.AppendText("\u221E ;");
                                }
                                else
                                {
                                    kryptonRichTextBox1.AppendText(d[i, j].ToString() + " ;");
                                }
                            }
                            kryptonRichTextBox1.AppendText("\n");
                        }
                        kryptonRichTextBox1.AppendText("-----\n");
                    }));
                }
                else if (e.Comment == "pred")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        int[,] pred = (int[,])e.Argument;
                        for (int i = 0; i < graph.VertexCollection.Count; i++)
                        {
                            for (int j = 0; j < graph.VertexCollection.Count; j++)
                            {
                                if (pred[i, j] == -1)
                                {
                                    kryptonRichTextBox2.AppendText("\u2205 ;");
                                }
                                else
                                {
                                    kryptonRichTextBox2.AppendText(pred[i, j].ToString() + " ;");
                                }
                            }
                            kryptonRichTextBox2.AppendText("\n");
                        }
                        kryptonRichTextBox2.AppendText("-----\n");
                    }));
                    t.Suspend();
                }
            }
        }

        private void graph_VertexAdded(object o, VertexEventArgs e)
        {
        }
        private void graph_VertexRemoved(object o, VertexEventArgs e)
        {
        }
        private void graph_EdgeAdded(object o, EdgeEventArgs e)
        {
        }
        private void graph_EdgeRemoved(object o, EdgeEventArgs e)
        {
        }
        private void kryptonPanel_Resize(object sender, EventArgs e)
        {
            Point newLocation = Point.Empty;
            if (kryptonPanel.Width > panel.ClientSize.Width)
            {
                newLocation.X = kryptonPanel.Width / 2 - panel.ClientSize.Width / 2;
            }
            if (kryptonPanel.Height > panel.ClientSize.Height)
            {
                newLocation.Y = kryptonPanel.Height / 2 - panel.ClientSize.Height / 2;
            }
            panel.Location = newLocation;
        }

        private void kryptonPanel1_Resize(object sender, EventArgs e)
        {
            Point newLocation = Point.Empty;
            if (kryptonPanel1.Width > kryptonPanel2.Width)
            {
                newLocation.X = kryptonPanel1.Width / 2 - kryptonPanel2.Width / 2;
            }
            kryptonPanel2.Location = newLocation;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (Vertex vertex in graph.VertexCollection)
            {
                e.Graphics.DrawFloydVertex(vertex);
            }
            foreach (Edge edge in graph.EdgeCollection)
            {
                e.Graphics.DrawEdge(edge);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            graph.DijkstraStepPerformed += new EventHandler<StepEventArgs>(graph_DijkstraStepPerformed);

            kryptonRichTextBox1.Text = "";
            kryptonRichTextBox2.Text = "";
            kryptonButton1.Enabled = false;
            kryptonButton2.Enabled = true;
            kryptonButton3.Enabled = true;
            ts = new ThreadStart(graph.CalculateFloydWarshall);
            t = new Thread(ts);
            t.Name = "FloydWarshall";
            t.Start();
        }
        private bool IsOverVertex(PointF p, Vertex vertex)
        {
            if (vertex == null) return false;
            return Functions.IsPointInsideCircle(p, vertex.Location, GraphicsExtensions.VertexRadius);
        }
        private void detectMouseOverVertex(PointF p)
        {
            if (!IsOverVertex(p, mouseOverVertex))
            {
                foreach (Vertex v in graph.VertexCollection)
                {
                    if (IsOverVertex(p, v))
                    {
                        if (mouseOverVertex != v)
                        {
                            mouseOverVertex = v;
                            panel.Invalidate();
                        }
                        break;
                    }
                    else
                    {
                        if (mouseOverVertex != null)
                        {
                            panel.Invalidate();
                            mouseOverVertex = null;
                        }
                    }
                }
            }
        }
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (choosingSourceVertex)
            {
                detectMouseOverVertex(e.Location);
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (choosingSourceVertex)
            {
                if (mouseOverVertex != null)
                {
                    graph.DijkstraStepPerformed += new EventHandler<StepEventArgs>(graph_DijkstraStepPerformed);
        
                    kryptonRichTextBox1.Text = "";
                    graph.Source = mouseOverVertex;
                    choosingSourceVertex = false;
                    panel.Invalidate();
                    kryptonButton1.Enabled = false;
                    kryptonButton2.Enabled = true;
                    kryptonButton3.Enabled = true;
                    ts = new ThreadStart(graph.CalculateDijkstra);
                    t = new Thread(ts);
                    t.Name = "Dijkstra";
                    t.Start();
                    panel.Invalidate();
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                if (t.ThreadState == System.Threading.ThreadState.Suspended)
                {
                    t.Resume();
                }
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                graph.DijkstraStepPerformed -= new EventHandler<StepEventArgs>(graph_DijkstraStepPerformed);
                if (t != null)
                {
                    if (t.ThreadState == System.Threading.ThreadState.Suspended)
                    {
                        t.Resume();
                    }
                    if (t.ThreadState == System.Threading.ThreadState.Running)
                    {
                        t.Abort();
                    }
                }
                kryptonButton1.Enabled = true;
                kryptonButton2.Enabled = false;
                kryptonButton3.Enabled = false;
                graph.Source = null;
                panel.Invalidate();
            }
        }

        private void DijkstraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            graph.DijkstraStepPerformed -= new EventHandler<StepEventArgs>(graph_DijkstraStepPerformed);
            if (t != null)
            {
                if (t.ThreadState == System.Threading.ThreadState.Suspended)
                {
                    t.Resume();
                }
                if (t.ThreadState == System.Threading.ThreadState.Running)
                {
                    t.Abort();
                }
            }
            Application.Exit();
        }

        private void FloydWarshallForm_Load(object sender, EventArgs e)
        {

            graph.CalculateFloydWarshall();
        }
    }
}