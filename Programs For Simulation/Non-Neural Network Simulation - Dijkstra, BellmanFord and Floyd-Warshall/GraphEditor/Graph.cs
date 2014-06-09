using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace GraphEditor
{
    public class Graph
    {
        public Boolean IsAutomaticWeights { get; set; }
        public VertexCollection VertexCollection { get; set; }
        public EdgeCollection EdgeCollection { get; set; }

        public event EventHandler<StepEventArgs> DijkstraStepPerformed;

        public event EventHandler<VertexEventArgs> VertexAdded
        {
            add { VertexCollection.VertexAdded += value; }
            remove { VertexCollection.VertexAdded -= value; }
        }
        public event EventHandler<VertexEventArgs> VertexRemoved
        {
            add { VertexCollection.VertexRemoved += value; }
            remove { VertexCollection.VertexRemoved -= value; }
        }
        public event EventHandler<EdgeEventArgs> EdgeAdded
        {
            add { EdgeCollection.EdgeAdded += value; }
            remove { EdgeCollection.EdgeAdded -= value; }
        }
        public event EventHandler<EdgeEventArgs> EdgeRemoved
        {
            add { EdgeCollection.EdgeRemoved += value; }
            remove { EdgeCollection.EdgeRemoved -= value; }
        }
        public Graph(Boolean isAutomaticWeights)
        {
            IsAutomaticWeights = isAutomaticWeights;
            VertexCollection = new VertexCollection(this);
            EdgeCollection = new EdgeCollection(this);
        }
        public void AddVertex(PointF location)
        {
            Vertex v = new Vertex(VertexCollection, location);
            VertexCollection.Add(v);
        }
        public void AddEdge(Vertex source, Vertex target)
        {
            if (!EdgeCollection.Contains(source, target))
            {
                EdgeCollection.Add(new Edge(EdgeCollection, source, target));
            }
        }
        public void AddEdge(Vertex source, Vertex target, Int32 weight)
        {
            if (!EdgeCollection.Contains(source, target))
            {
                EdgeCollection.Add(new Edge(EdgeCollection, source, target, weight));
            }
        }
        public void RemoveVertex(Vertex vertex)
        {
            VertexCollection.Remove(vertex);
        }
        public void RemoveEdge(Edge edge)
        {
            EdgeCollection.Remove(edge);
        }
        public Vertex Source = null;
        public Boolean abort = false;
        public void CalculateDijkstra()
        {
            OnDijkstraStepPerformed(new StepEventArgs("", "begin"));
            foreach (Vertex v in VertexCollection)// for each v∈V
            {
                v.Distance = Int32.MaxValue;// d[v]←∞
                v.Previous = null; // π[v]←∅
            }
            Source.Distance = 0;// d[s]←0
            OnDijkstraStepPerformed(new StepEventArgs("", "init"));
            List<Vertex> S = new List<Vertex>();// S←∅
            OnDijkstraStepPerformed(new StepEventArgs(S, "S"));
            List<Vertex> Q = VertexCollection.ToList();// Q←V

            bool finished = false;
            while (!finished)
            {
                Vertex u = Q.OrderBy(n => n.Distance).FirstOrDefault(n => n.Distance!=Int32.MaxValue);// u←ExtractMin(Q)
                if (u != null)
                {
                    Q.Remove(u);

                    OnDijkstraStepPerformed(new StepEventArgs(u, "min"));

                    foreach (Edge e in u.Edges)// for each v∈Adj[u]
                    {
                        Int32 distance = u.Distance + e.Weight;
                        if (distance < e.Target.Distance)// if d[v]<d[u]+w(u,v)
                        {
                            e.Target.Distance = distance;// d[v]←d[u]+w(u,v)
                            e.Target.Previous = u;// π[v]=u
                        }
                        OnDijkstraStepPerformed(new StepEventArgs(e, "relax"));
                    }
                    S.Add(u);// S←S∪{u}
                    OnDijkstraStepPerformed(new StepEventArgs(S, "S"));
                }
                else
                {
                    finished = true;
                }
            }
           OnDijkstraStepPerformed(new StepEventArgs("", "end"));
        }
        public void CalculateBellmanFord()
        {
            OnDijkstraStepPerformed(new StepEventArgs("", "begin"));
            foreach (Vertex v in VertexCollection)// for each v∈V
            {
                v.Distance = 2000000;// d[v]←∞
                v.Previous = null; // π[v]←∅
            }
            Source.Distance = 0;// d[s]←0if (abort) return;
            OnDijkstraStepPerformed(new StepEventArgs("", "init"));
            for (int i = 1; i < VertexCollection.Count; i++)
            {
                OnDijkstraStepPerformed(new StepEventArgs(i, "loop"));
                foreach (Edge e in EdgeCollection)
                {
                    if (e.Target.Distance > e.Source.Distance + e.Weight)
                    {
                        e.Target.Distance = e.Source.Distance + e.Weight;
                        e.Target.Previous = e.Source;
                    }
                    OnDijkstraStepPerformed(new StepEventArgs(e, "relax"));
                }
            }
            OnDijkstraStepPerformed(new StepEventArgs("", "end"));
        }

        public void CalculateFloydWarshall()
        {
            OnDijkstraStepPerformed(new StepEventArgs("", "begin"));
            int[,] d = new int[VertexCollection.Count, VertexCollection.Count];
            int[,] pred = new int[VertexCollection.Count, VertexCollection.Count];

            for (int i = 0; i < VertexCollection.Count; i++)
            {
                for (int j = 0; j < VertexCollection.Count; j++)
                {
                    Edge e = EdgeCollection[VertexCollection[i], VertexCollection[j]];

                    if (i == j)
                    {
                        d[i, j] = 0;
                    }
                    else if (e == null)
                    {
                        d[i, j] = 9999;
                    }
                    else
                    {
                        d[i, j] = e.Weight;
                    }
                }
            }

            OnDijkstraStepPerformed(new StepEventArgs(d, "dinit"));
            for (int i = 0; i < VertexCollection.Count; i++)
            {
                for (int j = 0; j < VertexCollection.Count; j++)
                {
                    if (d[i, j] == 9999 || i == j)
                    {
                        pred[i, j] = -1;
                    }
                    else
                    {
                        pred[i, j] = i;
                    }
                }
            }

            OnDijkstraStepPerformed(new StepEventArgs(pred, "predinit"));
            for (int k = 0; k < VertexCollection.Count; k++)
            {
                for (int i = 0; i < VertexCollection.Count; i++)
                {
                    for (int j = 0; j < VertexCollection.Count; j++)
                    {
                        if (d[i, k] + d[k, j] < d[i, j])
                        {
                            d[i, j] = d[i, k] + d[k, j];
                            pred[i, j] = pred[k, j];
                        }
                    }
                }

                OnDijkstraStepPerformed(new StepEventArgs(d, "d"));
                OnDijkstraStepPerformed(new StepEventArgs(pred, "pred"));
            }
            OnDijkstraStepPerformed(new StepEventArgs("", "end"));
        }

        protected virtual void OnDijkstraStepPerformed(StepEventArgs e)
        {
            if (DijkstraStepPerformed != null) DijkstraStepPerformed(this, e);
        }
    }
}
