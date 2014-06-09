using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphEditor
{
    public class VertexEventArgs : EventArgs
    {
        public Vertex Vertex
        {
            get;
            private set;
        }
        public VertexEventArgs(Vertex vertex)
        {
            Vertex = vertex;
        }
    }
}
