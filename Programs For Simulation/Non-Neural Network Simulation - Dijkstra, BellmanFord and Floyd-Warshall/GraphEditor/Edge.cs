using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphEditor
{
    public class Edge
    {
        public EdgeCollection EdgeCollection { get; set; }
        public Vertex Source { get; set; }
        public Vertex Target { get; set; }
        public int Weight { get; set; }
       

        public Edge(EdgeCollection edgeCollection, Vertex source, Vertex target)
        {
            EdgeCollection = edgeCollection;
            Source = source;
            Target = target;
            Weight = new Random().Next(0, 50);
        }

        public Edge(EdgeCollection edgeCollection, Vertex source, Vertex target, int weight)
        {
            EdgeCollection = edgeCollection;
            Source = source;
            Target = target;
            Weight = weight;
        }
        public override string ToString()
        {
            return Source.ToString() + " > " + Target.ToString();
        }
    }
}
