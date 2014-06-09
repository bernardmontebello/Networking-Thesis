using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace GraphEditor
{
    public class VertexCollection : ReadOnlyCollection<Vertex>
    {
        public Graph Graph { get; set; }
        public event EventHandler<VertexEventArgs> VertexAdded;
        public event EventHandler<VertexEventArgs> VertexRemoved;

        public VertexCollection(Graph graph)
            : base(new List<Vertex>())
        {
            Graph = graph;
        }
        public void Add(Vertex vertex)
        {
            this.Items.Add(vertex);
            OnVertexAdded(new VertexEventArgs(vertex));
        }
        public void Remove(Vertex vertex)
        {
            foreach (Edge e in new List<Edge>(Graph.EdgeCollection))
            {
                if (e.Source == vertex || e.Target == vertex) Graph.EdgeCollection.Remove(e);
            }
            this.Items.Remove(vertex);
            OnVertexRemoved(new VertexEventArgs(vertex));
        }
        protected virtual void OnVertexAdded(VertexEventArgs e)
        {
            if (VertexAdded != null) VertexAdded(this, e);
        }

        protected virtual void OnVertexRemoved(VertexEventArgs e)
        {
            if (VertexRemoved != null) VertexRemoved(this, e);
        }
    }
}
