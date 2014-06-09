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
    public partial class DijkstraForm : ComponentFactory.Krypton.Toolkit.KryptonForm
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

        public DijkstraForm(Boolean isVertical)
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
            if (e.Argument is String)
            {
                if (e.Comment == "begin")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        kryptonRichTextBox1.AppendText("Algorithm begin\nSource vertex is " + graph.Source.Key + "\n");

                    }));
                    t.Suspend();
                }
                else if (e.Comment == "init")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        kryptonRichTextBox1.AppendText("Graph initialized\n");
                        panel.Invalidate();
                    }));
                    t.Suspend();
                }
                else if (e.Comment == "end")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        kryptonRichTextBox1.AppendText("Algorithm end\n");
                        u = null;
                        uv = null;
                        panel.Invalidate();
                    }));
                }
            }
            else if (e.Argument is List<Vertex>)
            {
                if (e.Comment == "S")
                {
                    this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                    {
                        S = (List<Vertex>)e.Argument;
                        panel.Invalidate();
                    }));
                }
            }
            else if (e.Argument is Vertex)
            {
                this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                {
                    uv = null;
                    u = (Vertex)e.Argument;
                    panel.Invalidate();
                    kryptonRichTextBox1.AppendText("u = " + u.Key + "\n");
                }));
                t.Suspend();
            }
            else if (e.Argument is Edge)
            {
                this.BeginInvoke(new MethodInvoker(delegate() // ðis ir lai varçtu no viena threada varetu mainiit otru threadu (no servera threada izmaniniit formas threadu)
                {
                    uv= (Edge)e.Argument;
                    panel.Invalidate();
                    kryptonRichTextBox1.AppendText("Relax " + uv.ToString() + "\n");
                }));
                t.Suspend();
            }
            //Debug.WriteLine(e.Comment);
        }

        private void graph_VertexAdded(object o, VertexEventArgs e)
        {
            vertexListBox.Items.Add(e.Vertex);
        }
        private void graph_VertexRemoved(object o, VertexEventArgs e)
        {
            vertexListBox.Items.Remove(e.Vertex);
        }
        private void graph_EdgeAdded(object o, EdgeEventArgs e)
        {
            edgeListBox.Items.Add(e.Edge);
        }
        private void graph_EdgeRemoved(object o, EdgeEventArgs e)
        {
            edgeListBox.Items.Remove(e.Edge);
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
            if (choosingSourceVertex)
            {
                if (mouseOverVertex != null)
                {
                        e.Graphics.DrawMouseOverVertex(mouseOverVertex);
                }
            }
            if (graph.Source != null)
            {
                e.Graphics.DrawSourceVertex(graph.Source);
            }
            
            foreach (Vertex vertex in graph.VertexCollection)
            {
                e.Graphics.DrawDijkstraVertex(vertex, (vertex == u), S.Contains(vertex));
            }
            foreach (Edge edge in graph.EdgeCollection)
            {
                e.Graphics.DrawDijkstraEdge(edge, (edge == uv));
                //e.Graphics.DrawEdge(edge);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("Now select source vertex!");
            choosingSourceVertex = true;
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
    }
}