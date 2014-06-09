using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphEditor
{
    public class Vertex
    {
        public VertexCollection VertexCollection { get; set; }
        public PointF Location { get; set; }
        public Vertex Previous { get; set; }
        public Int32 Distance { get; set; }
        public String Key
        {
            get
            {
                return Functions.GetAutomaticLabel(VertexCollection.IndexOf(this));
            }
        }
        public IEnumerable<Edge> Edges
        {
            get
            {
                return this.VertexCollection.Graph.EdgeCollection.Where(edge => edge.Source == this);
            }
        }

        public Vertex(VertexCollection vertexCollection, PointF location)
        {
            VertexCollection = vertexCollection;
            Location = location;
        }

        public override string ToString()
        {
            return Key;
        }

    }
}
