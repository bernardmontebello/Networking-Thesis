using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphEditor
{
    public class StepEventArgs : EventArgs
    {
        public Object Argument { get; private set; }
        public String Comment { get; private set; }
        public StepEventArgs(Object arguent, String comment)
        {
            Argument = arguent;
            Comment = comment;
        }
    }
}
