using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Xml;

namespace GraphEditor
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            using (NewGraphDialog ngd = new NewGraphDialog())
            {
                if (ngd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    EditorForm rf = new EditorForm(ngd.isVertical, ngd.isAutomaticWeights);
                    rf.MdiParent = this;
                    rf.Show();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild is EditorForm)
                {
                    EditorForm ef = (EditorForm)ActiveMdiChild;
                    using (SaveFileDialog ofd = new SaveFileDialog())
                    {
                        ofd.Filter = "XML files|*.xml;";
                        if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            XmlTextWriter writer = new XmlTextWriter(ofd.FileName, System.Text.Encoding.ASCII);
                            writer.WriteStartElement("Graph");
                            writer.WriteStartElement("O");
                            writer.WriteAttributeString("vertical", ef.isVertical.ToString());
                            writer.WriteAttributeString("randomEdges", ef.graph.IsAutomaticWeights.ToString());
                            writer.WriteEndElement();
                            foreach (Vertex v in ef.graph.VertexCollection)
                            {
                                writer.WriteStartElement("V");
                                writer.WriteAttributeString("X", v.Location.X.ToString());
                                writer.WriteAttributeString("Y", v.Location.Y.ToString());
                                writer.WriteEndElement();//EndVertex
                            }
                            foreach (Edge ed in ef.graph.EdgeCollection)
                            {
                                writer.WriteStartElement("E");
                                writer.WriteAttributeString("S", ef.graph.VertexCollection.IndexOf(ed.Source).ToString());
                                writer.WriteAttributeString("T", ef.graph.VertexCollection.IndexOf(ed.Target).ToString());
                                writer.WriteAttributeString("W", ed.Weight.ToString());
                                writer.WriteEndElement();//EndEdge
                            }
                            writer.WriteEndElement();
                            writer.Close();
                        }
                    }                    
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files|*.xml;";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(ofd.FileName);

                        XmlNodeList options = xmlDoc.GetElementsByTagName("O");
                        XmlNode option = options[0];
                        Boolean isVertical = Convert.ToBoolean(option.Attributes["vertical"].InnerText);
                        Boolean isRandom = Convert.ToBoolean(option.Attributes["randomEdges"].InnerText);

                        XmlNodeList Vertexes = xmlDoc.GetElementsByTagName("V");
                        XmlNodeList Edges = xmlDoc.GetElementsByTagName("E");

                        EditorForm ef = new EditorForm(isVertical, isRandom);

                        foreach (XmlNode v in Vertexes)
                        {
                            ef.graph.AddVertex(new PointF(Convert.ToSingle(v.Attributes["X"].InnerText), Convert.ToSingle(v.Attributes["Y"].InnerText)));
                        }
                        foreach (XmlNode ed in Edges)
                        {
                            ef.graph.AddEdge(ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["S"].InnerText)], ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["T"].InnerText)], Convert.ToInt32(ed.Attributes["W"].InnerText));
                        }
                        ef.MdiParent = this;
                        ef.Show();
                    }
                    catch (Exception) { KryptonMessageBox.Show("Couldnt open file", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void openDijkstraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files|*.xml;";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(ofd.FileName);

                        XmlNodeList options = xmlDoc.GetElementsByTagName("O");
                        XmlNode option = options[0];
                        Boolean isVertical = Convert.ToBoolean(option.Attributes["vertical"].InnerText);
                        Boolean isRandom = Convert.ToBoolean(option.Attributes["randomEdges"].InnerText);

                        XmlNodeList Vertexes = xmlDoc.GetElementsByTagName("V");
                        XmlNodeList Edges = xmlDoc.GetElementsByTagName("E");

                        DijkstraForm ef = new DijkstraForm(isVertical);

                        foreach (XmlNode v in Vertexes)
                        {
                            ef.graph.AddVertex(new PointF(Convert.ToSingle(v.Attributes["X"].InnerText), Convert.ToSingle(v.Attributes["Y"].InnerText)));
                        }
                        foreach (XmlNode ed in Edges)
                        {
                            ef.graph.AddEdge(ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["S"].InnerText)], ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["T"].InnerText)], Convert.ToInt32(ed.Attributes["W"].InnerText));
                        }
                        ef.MdiParent = this;
                        ef.Show();
                    }
                    catch (Exception) { KryptonMessageBox.Show("Couldnt open file", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void openBellmanFordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files|*.xml;";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(ofd.FileName);

                        XmlNodeList options = xmlDoc.GetElementsByTagName("O");
                        XmlNode option = options[0];
                        Boolean isVertical = Convert.ToBoolean(option.Attributes["vertical"].InnerText);
                        Boolean isRandom = Convert.ToBoolean(option.Attributes["randomEdges"].InnerText);

                        XmlNodeList Vertexes = xmlDoc.GetElementsByTagName("V");
                        XmlNodeList Edges = xmlDoc.GetElementsByTagName("E");

                        BellmanFordForm ef = new BellmanFordForm(isVertical);

                        foreach (XmlNode v in Vertexes)
                        {
                            ef.graph.AddVertex(new PointF(Convert.ToSingle(v.Attributes["X"].InnerText), Convert.ToSingle(v.Attributes["Y"].InnerText)));
                        }
                        foreach (XmlNode ed in Edges)
                        {
                            ef.graph.AddEdge(ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["S"].InnerText)], ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["T"].InnerText)], Convert.ToInt32(ed.Attributes["W"].InnerText));
                        }
                        ef.MdiParent = this;
                        ef.Show();
                    }
                    catch (Exception) { KryptonMessageBox.Show("Couldnt open file", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportAsPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG file|*.png;";
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (ActiveMdiChild is EditorForm)
                        {
                            EditorForm f = (EditorForm)ActiveMdiChild;
                            f.SaveImate(sfd.FileName);

                        }
                        else if (ActiveMdiChild is DijkstraForm)
                        {
                            DijkstraForm f = (DijkstraForm)ActiveMdiChild;
                            f.SaveImate(sfd.FileName);
                        }
                        else if (ActiveMdiChild is BellmanFordForm)
                        {
                            BellmanFordForm f = (BellmanFordForm)ActiveMdiChild;
                            f.SaveImate(sfd.FileName);
                        }
                    }
                }
            }
        }

        private void openFloydWarshallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files|*.xml;";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(ofd.FileName);

                        XmlNodeList options = xmlDoc.GetElementsByTagName("O");
                        XmlNode option = options[0];
                        Boolean isVertical = Convert.ToBoolean(option.Attributes["vertical"].InnerText);
                        Boolean isRandom = Convert.ToBoolean(option.Attributes["randomEdges"].InnerText);

                        XmlNodeList Vertexes = xmlDoc.GetElementsByTagName("V");
                        XmlNodeList Edges = xmlDoc.GetElementsByTagName("E");

                        FloydWarshallForm ef = new FloydWarshallForm(isVertical);

                        foreach (XmlNode v in Vertexes)
                        {
                            ef.graph.AddVertex(new PointF(Convert.ToSingle(v.Attributes["X"].InnerText), Convert.ToSingle(v.Attributes["Y"].InnerText)));
                        }
                        foreach (XmlNode ed in Edges)
                        {
                            ef.graph.AddEdge(ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["S"].InnerText)], ef.graph.VertexCollection[Convert.ToInt32(ed.Attributes["T"].InnerText)], Convert.ToInt32(ed.Attributes["W"].InnerText));
                        }
                        ef.MdiParent = this;
                        ef.Show();
                    }
                    catch (Exception) { KryptonMessageBox.Show("Couldnt open file", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}