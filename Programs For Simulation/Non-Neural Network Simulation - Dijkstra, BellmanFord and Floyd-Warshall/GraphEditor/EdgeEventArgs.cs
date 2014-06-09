using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphEditor
{
    public class EdgeEventArgs : EventArgs
    {
        public Edge Edge
        {
            get;
            private set;
        }

        public EdgeEventArgs(Edge edge)
        {
            Edge = edge;
        }
    }
}
