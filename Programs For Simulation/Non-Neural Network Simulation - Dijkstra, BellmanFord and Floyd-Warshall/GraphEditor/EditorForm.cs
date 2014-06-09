using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;

namespace GraphEditor
{
    public partial class EditorForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public void SaveImate(String filename)
        {
            using (var bmp = new Bitmap(panel.Width, panel.Width))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.Clear(Color.White);
                    if (addVertexToolStripButton.Checked)
                    {
                        if (IsMouseInside)
                        {
                            g.DrawVertexCircle(MouseLocation);
                        }
                    }
                    else if (addEdgeToolStripButton.Checked)
                    {
                        if (mouseOverVertex != null)
                        {
                            g.DrawMouseOverVertex(mouseOverVertex);
                        }
                        if (selectedVertex != null)
                        {
                            g.DrawMouseOverVertex(selectedVertex);
                            if (mouseOverVertex == null)
                            {
                                g.DrawAddEdge(selectedVertex, MouseLocation);
                            }
                            else if (mouseOverVertex != selectedVertex)
                            {
                                g.DrawAddEdge(selectedVertex, mouseOverVertex);
                            }
                        }
                    }
                    else if (moveVertexToolStripButton.Checked)
                    {
                        if (mouseOverVertex != null)
                        {
                            g.DrawMouseOverVertex(mouseOverVertex);
                        }
                        if (selectedVertex != null)
                        {
                            if (selectedVertex != mouseOverVertex)
                            {
                                g.DrawMouseOverVertex(selectedVertex);
                            }
                        }

                    }
                    else if (removeVertexToolStripButton.Checked)
                    {
                        if (mouseOverVertex != null)
                        {
                            g.DrawMouseOverVertex(mouseOverVertex);
                        }
                    }
                    else if (removeEdgeToolStripButton.Checked)
                    {
                        if (mouseOverVertex != null)
                        {
                            g.DrawMouseOverVertex(mouseOverVertex);
                        }
                        if (selectedVertex != null)
                        {
                            if (mouseOverVertex != selectedVertex)
                            {
                                g.DrawMouseOverVertex(selectedVertex);
                            }
                        }
                    }
                    else if (editEdgeWeightToolStripButton.Checked)
                    {
                        if (mouseOverVertex != null)
                        {
                            g.DrawMouseOverVertex(mouseOverVertex);
                        }
                        if (selectedVertex != null)
                        {
                            if (mouseOverVertex != selectedVertex)
                            {
                                g.DrawMouseOverVertex(selectedVertex);
                            }
                        }
                    }

                    foreach (Vertex vertex in graph.VertexCollection)
                    {
                        g.DrawVertex(vertex);
                    }
                    foreach (Edge edge in graph.EdgeCollection)
                    {
                        g.DrawEdge(edge);
                    }
                    bmp.Save(filename);
                }
            }

        }
        public Graph graph;
        Vertex mouseOverVertex = null;
        private Boolean IsMouseInside = false;
        private Boolean IsMouseDown = false;
        private Point MouseLocation = Point.Empty;
        private Vertex selectedVertex = null;
        public Boolean isVertical
        {
            get { return panel.Height > panel.Width; }
        }
        public EditorForm(Boolean vertical, Boolean isAutomaticWeights)
        {
            InitializeComponent();
            graph = new Graph(isAutomaticWeights);
            graph.VertexAdded += new EventHandler<VertexEventArgs>(graph_VertexAdded);
            graph.VertexRemoved += new EventHandler<VertexEventArgs>(graph_VertexRemoved);
            graph.EdgeAdded += new EventHandler<EdgeEventArgs>(graph_EdgeAdded);
            graph.EdgeRemoved += new EventHandler<EdgeEventArgs>(graph_EdgeRemoved);
            panel.Size = vertical ? new Size(3000, 3000) : new Size(3000, 3000);
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

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (addVertexToolStripButton.Checked)
            {
                if (IsMouseInside)
                {
                    e.Graphics.DrawVertexCircle(MouseLocation);
                }
            }
            else if (addEdgeToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    e.Graphics.DrawMouseOverVertex(mouseOverVertex);
                }
                if (selectedVertex != null)
                {
                    e.Graphics.DrawMouseOverVertex(selectedVertex);
                    if (mouseOverVertex == null)
                    {
                        e.Graphics.DrawAddEdge(selectedVertex, MouseLocation);
                    }
                    else if (mouseOverVertex != selectedVertex)
                    {
                        e.Graphics.DrawAddEdge(selectedVertex, mouseOverVertex);
                    }
                }
            }
            else if (moveVertexToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    e.Graphics.DrawMouseOverVertex(mouseOverVertex);
                }
                if (selectedVertex != null)
                {
                    if (selectedVertex != mouseOverVertex)
                    {
                        e.Graphics.DrawMouseOverVertex(selectedVertex);
                    }
                }

            }
            else if (removeVertexToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    e.Graphics.DrawMouseOverVertex(mouseOverVertex);
                }
            }
            else if (removeEdgeToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    e.Graphics.DrawMouseOverVertex(mouseOverVertex);
                }
                if (selectedVertex != null)
                {
                    if (mouseOverVertex != selectedVertex)
                    {
                        e.Graphics.DrawMouseOverVertex(selectedVertex);
                    }
                }
            }
            else if (editEdgeWeightToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    e.Graphics.DrawMouseOverVertex(mouseOverVertex);
                }
                if (selectedVertex != null)
                {
                    if (mouseOverVertex != selectedVertex)
                    {
                        e.Graphics.DrawMouseOverVertex(selectedVertex);
                    }
                }
            }
            
            foreach (Vertex vertex in graph.VertexCollection)
            {
                e.Graphics.DrawVertex(vertex);
            }
            foreach (Edge edge in graph.EdgeCollection)
            {
                e.Graphics.DrawEdge(edge);
            }
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
        private void panel_MouseEnter(object sender, EventArgs e)
        {
            IsMouseInside = true;
            panel.Invalidate();
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            IsMouseInside = false;
            panel.Invalidate();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLocation = e.Location;
            if (addVertexToolStripButton.Checked)
            {
                panel.Invalidate();
            }
            else if (addEdgeToolStripButton.Checked)
            {
                detectMouseOverVertex(e.Location);
                if (selectedVertex != null) panel.Invalidate();
            }
            else if (moveVertexToolStripButton.Checked)
            {
                if (IsMouseDown)
                {
                    if (selectedVertex != null)
                    {
                        selectedVertex.Location = e.Location;
                        panel.Invalidate();
                    }
                }
                else
                {
                    detectMouseOverVertex(e.Location);
                }
            }
            else if (removeVertexToolStripButton.Checked)
            {
                detectMouseOverVertex(e.Location);
            }
            else if (removeEdgeToolStripButton.Checked)
            {
                detectMouseOverVertex(e.Location);
            }
            else if (editEdgeWeightToolStripButton.Checked)
            {
                detectMouseOverVertex(e.Location);
            }
        }

        private void addVertexToolStripButton_Click(object sender, EventArgs e)
        {
            addVertexToolStripButton.Checked = !addVertexToolStripButton.Checked;
            addEdgeToolStripButton.Checked = false;
            moveVertexToolStripButton.Checked = false;
            removeVertexToolStripButton.Checked = false;
            removeEdgeToolStripButton.Checked = false;
            editEdgeWeightToolStripButton.Checked = false;
        }

        private void addEdgeToolStripButton_Click(object sender, EventArgs e)
        {
            addVertexToolStripButton.Checked = false;
            addEdgeToolStripButton.Checked = !addEdgeToolStripButton.Checked;
            moveVertexToolStripButton.Checked = false;
            removeVertexToolStripButton.Checked = false;
            removeEdgeToolStripButton.Checked = false;
            editEdgeWeightToolStripButton.Checked = false;
        }

        private void moveVertexToolStripButton_Click(object sender, EventArgs e)
        {
            addVertexToolStripButton.Checked = false;
            addEdgeToolStripButton.Checked = false;
            moveVertexToolStripButton.Checked = !moveVertexToolStripButton.Checked;
            removeVertexToolStripButton.Checked = false;
            removeEdgeToolStripButton.Checked = false;
            editEdgeWeightToolStripButton.Checked = false;
        }


        private void removeVertexToolStripButton_Click(object sender, EventArgs e)
        {
            addVertexToolStripButton.Checked = false;
            addEdgeToolStripButton.Checked = false;
            moveVertexToolStripButton.Checked = false;
            removeVertexToolStripButton.Checked = !removeVertexToolStripButton.Checked;
            removeEdgeToolStripButton.Checked = false;
            editEdgeWeightToolStripButton.Checked = false;
        }

        private void removeEdgeToolStripButton_Click(object sender, EventArgs e)
        {
            addVertexToolStripButton.Checked = false;
            addEdgeToolStripButton.Checked = false;
            moveVertexToolStripButton.Checked = false;
            removeVertexToolStripButton.Checked = false;
            removeEdgeToolStripButton.Checked = !removeEdgeToolStripButton.Checked;
            editEdgeWeightToolStripButton.Checked = false;
        }
        private void editEdgeWeightToolStripButton_Click(object sender, EventArgs e)
        {
            addVertexToolStripButton.Checked = false;
            addEdgeToolStripButton.Checked = false;
            moveVertexToolStripButton.Checked = false;
            removeVertexToolStripButton.Checked = false;
            removeEdgeToolStripButton.Checked = false;
            editEdgeWeightToolStripButton.Checked = !editEdgeWeightToolStripButton.Checked;
        }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (addVertexToolStripButton.Checked)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if (IsMouseInside)
                    {
                        graph.AddVertex(e.Location);
                    }
                }
            }
            else if (addEdgeToolStripButton.Checked)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if (mouseOverVertex != null)
                    {
                        if (selectedVertex == null)
                        {
                            selectedVertex = mouseOverVertex;
                            panel.Invalidate();
                        }
                        else
                        {
                            if (mouseOverVertex != selectedVertex)
                            {
                                if (graph.IsAutomaticWeights)
                                {
                                    graph.AddEdge(selectedVertex, mouseOverVertex);
                                }
                                else
                                {
                                    using (EdgeWightInputDialog ewid = new EdgeWightInputDialog())
                                    {
                                        if (ewid.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                        {
                                            graph.AddEdge(selectedVertex, mouseOverVertex, ewid.Value);
                                        }
                                    }
                                }
                                mouseOverVertex = null;
                                selectedVertex = null;
                                panel.Invalidate();
                            }
                        }
                    }
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    if (selectedVertex != null)
                    {
                        selectedVertex = null;
                        panel.Invalidate();
                    }
                }
            }
            else if (moveVertexToolStripButton.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (mouseOverVertex != null)
                    {
                        selectedVertex = mouseOverVertex;
                        IsMouseDown = true;
                        panel.Invalidate();
                    }
                }
            }
            else if (removeVertexToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        graph.RemoveVertex(mouseOverVertex);
                        mouseOverVertex = null;
                        panel.Invalidate();
                    }
                }
            }
            else if (editEdgeWeightToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    if (selectedVertex == null)
                    {
                        selectedVertex = mouseOverVertex;
                        panel.Invalidate();
                    }
                    else
                    {
                        if (mouseOverVertex != selectedVertex)
                        {
                            Edge edge = graph.EdgeCollection[selectedVertex, mouseOverVertex];
                            if (edge != null)
                            {
                                using (EdgeWightInputDialog ewid = new EdgeWightInputDialog())
                                {
                                    if (ewid.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    {
                                        edge.Weight = ewid.Value;
                                    }
                                }
                            }
                            mouseOverVertex = null;
                            selectedVertex = null;
                            panel.Invalidate();
                        }
                    }
                }
            }
            else if (removeEdgeToolStripButton.Checked)
            {
                if (mouseOverVertex != null)
                {
                    if (selectedVertex == null)
                    {
                        selectedVertex = mouseOverVertex;
                        panel.Invalidate();
                    }
                    else
                    {
                        if (mouseOverVertex != selectedVertex)
                        {
                            Edge edge = graph.EdgeCollection[selectedVertex, mouseOverVertex];
                            graph.RemoveEdge(edge);
                            mouseOverVertex = null;
                            selectedVertex = null;
                            panel.Invalidate();
                        }
                    }
                }
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (moveVertexToolStripButton.Checked)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    IsMouseDown = false;
                    selectedVertex = null;
                    panel.Invalidate();
                }
            }
        }


    }
}