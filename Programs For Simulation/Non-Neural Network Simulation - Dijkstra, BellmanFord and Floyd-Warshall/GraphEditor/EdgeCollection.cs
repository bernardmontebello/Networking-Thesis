using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace GraphEditor
{
    public class EdgeCollection : ReadOnlyCollection<Edge>
    {
        public Graph Graph { get; set; }
        public event EventHandler<EdgeEventArgs> EdgeAdded;
        public event EventHandler<EdgeEventArgs> EdgeRemoved;
        public Edge this[Vertex Source, Vertex Target]
        {
            get
            {
                return this.FirstOrDefault(Edge => Edge.Source == Source && Edge.Target == Target);
            }
        }
        public EdgeCollection(Graph graph)
            : base(new List<Edge>())
        {
            Graph = graph;
        }
        public void Add(Edge edge)
        {
            this.Items.Add(edge);
            OnEdgeAdded(new EdgeEventArgs(edge));
        }
        public void Remove(Edge edge)
        {
            this.Items.Remove(edge);
            this.OnEdgeRemoved(new EdgeEventArgs(edge));
        }
        public Boolean Contains(Vertex source, Vertex target)
        {
            return this.Any(edge => edge.Source == source && edge.Target == target);
        }
        protected virtual void OnEdgeAdded(EdgeEventArgs e)
        {
            if (EdgeAdded != null) EdgeAdded(this, e);
        }
        protected virtual void OnEdgeRemoved(EdgeEventArgs e)
        {
            if (EdgeRemoved != null) EdgeRemoved(this, e);
        }
    }
}
