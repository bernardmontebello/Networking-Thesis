using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphEditor
{
    public class PanelDoubleBuffered : Panel
    {
        public PanelDoubleBuffered()
            : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
    }
}
