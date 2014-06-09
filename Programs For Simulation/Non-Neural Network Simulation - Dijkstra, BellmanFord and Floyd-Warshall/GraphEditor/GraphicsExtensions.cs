using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphEditor
{
    public static class GraphicsExtensions
    {
        public static Single VertexRadius = 25;
        private static SizeF VertexSize = new SizeF(VertexRadius * 2, VertexRadius * 2);
        private static Pen VertexStroke = new Pen(Color.Blue, 3);
        private static StringFormat WeightStringFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        private static Pen EdgePen = new Pen(Color.Blue, 3) { CustomEndCap = new AdjustableArrowCap(3, 7) };
        private static Brush MouseOverVertexBrush = new SolidBrush(Color.FromArgb(127, Color.LightBlue));
        private static Font attFont = new Font("Arial", 8);
        private static Font LabelFont = new Font("Arial", 12, FontStyle.Bold);
        private static Pen CurrentVertexStroke = new Pen(Color.Red, 3);
        private static Brush SourceVertexBrush = new SolidBrush(Color.FromArgb(80, Color.Blue));
        private static Pen CurrentEdgePen = new Pen(Color.Red, 3) { CustomEndCap = new AdjustableArrowCap(3, 7) };
        private static Brush VisitedVertexBrush = new SolidBrush(Color.FromArgb(80, Color.Red));
        
        public static void DrawVertexCircle(this Graphics g, PointF p)
        {
            g.DrawEllipse(VertexStroke, p.X - VertexRadius, p.Y - VertexRadius, VertexRadius * 2, VertexRadius * 2);
        }
        public static void DrawMouseOverVertex(this Graphics g, Vertex vertex)
        {
            g.FillEllipse(MouseOverVertexBrush, vertex.Location.X - VertexRadius, vertex.Location.Y - VertexRadius, VertexRadius * 2, VertexRadius * 2);
        }
        public static void DrawSourceVertex(this Graphics g, Vertex vertex)
        {
            g.FillEllipse(SourceVertexBrush, vertex.Location.X - VertexRadius, vertex.Location.Y - VertexRadius, VertexRadius * 2, VertexRadius * 2);
        }

        public static void DrawDijkstraVertex(this Graphics g, Vertex vertex, Boolean isCurrent, Boolean isVisited)
        {
            if (isVisited)
            {
                g.DrawSourceVertex(vertex);
            }
            g.DrawEllipse(isCurrent ? CurrentVertexStroke : VertexStroke, vertex.Location.X - VertexRadius, vertex.Location.Y - VertexRadius, VertexRadius * 2, VertexRadius * 2);
            g.DrawString(vertex.Key, SystemFonts.DefaultFont, Brushes.Black, vertex.Location.X, vertex.Location.Y - 13, WeightStringFormat);
            StringBuilder s = new StringBuilder();
            s.Append("\u03B4");
            s.Append("=");
            s.Append(vertex.Distance >= 2000000 ? "\u221E" : vertex.Distance.ToString());
            s.Append("\n");
            s.Append("\u03C0");
            s.Append("=");
            s.Append(vertex.Previous == null ? "\u2205" : vertex.Previous.Key);
            g.DrawString(s.ToString(), attFont, Brushes.Black, vertex.Location.X, vertex.Location.Y + 8, WeightStringFormat);
        }
        public static void DrawFloydVertex(this Graphics g, Vertex vertex)
        {
            g.DrawEllipse(VertexStroke, vertex.Location.X - VertexRadius, vertex.Location.Y - VertexRadius, VertexRadius * 2, VertexRadius * 2);
            g.DrawString(vertex.VertexCollection.IndexOf(vertex).ToString(), SystemFonts.DefaultFont, Brushes.Black, vertex.Location, WeightStringFormat);
        
        }
        public static void DrawVertex(this Graphics g, Vertex vertex)
        {
            g.DrawEllipse(VertexStroke, vertex.Location.X - VertexRadius, vertex.Location.Y - VertexRadius, VertexRadius * 2, VertexRadius * 2);
            g.DrawString(vertex.Key, SystemFonts.DefaultFont, Brushes.Black, vertex.Location, WeightStringFormat);
        }

        public static void DrawAddEdge(this Graphics g, Vertex source, PointF mouseLocaion)
        {
            PointF[] controlPoints = Functions.DivideLine(source.Location, mouseLocaion, 3);
            PointF[] centerPoints = Functions.DivideLine(source.Location, mouseLocaion, 2);
            PointF control1 = Functions.Prependicular(source.Location, mouseLocaion, controlPoints[0], 10);
            PointF control2 = Functions.Prependicular(source.Location, mouseLocaion, controlPoints[1], 10);
            PointF weigth = Functions.Prependicular(source.Location, mouseLocaion, centerPoints[0], 22);
            PointF newSource = Functions.getPointOnCircle(source.Location, control1, 25);
            PointF newTarget = Functions.getPointOnCircle(mouseLocaion, control2, 25);

            g.DrawBezier(EdgePen, newSource, control1, control2, mouseLocaion);
        }
        public static void DrawAddEdge(this Graphics g, Vertex source, Vertex target)
        {
            PointF[] controlPoints = Functions.DivideLine(source.Location, target.Location, 3);
            PointF[] centerPoints = Functions.DivideLine(source.Location, target.Location, 2);
            PointF control1 = Functions.Prependicular(source.Location, target.Location, controlPoints[0], 10);
            PointF control2 = Functions.Prependicular(source.Location, target.Location, controlPoints[1], 10);
            PointF weigth = Functions.Prependicular(source.Location, target.Location, centerPoints[0], 22);
            PointF newSource = Functions.getPointOnCircle(source.Location, control1, 25);
            PointF newTarget = Functions.getPointOnCircle(target.Location, control2, 25);
            g.DrawBezier(EdgePen, newSource, control1, control2, newTarget);
        }

        public static void DrawDijkstraEdge(this Graphics g, Edge edge, Boolean isCurrent)
        {
            PointF[] controlPoints = Functions.DivideLine(edge.Source.Location, edge.Target.Location, 3);
            PointF[] centerPoints = Functions.DivideLine(edge.Source.Location, edge.Target.Location, 2);
            PointF control1 = Functions.Prependicular(edge.Source.Location, edge.Target.Location, controlPoints[0], 10);
            PointF control2 = Functions.Prependicular(edge.Source.Location, edge.Target.Location, controlPoints[1], 10);
            PointF weigth = Functions.Prependicular(edge.Source.Location, edge.Target.Location, centerPoints[0], 22);
            PointF newSource = Functions.getPointOnCircle(edge.Source.Location, control1, 25);
            PointF newTarget = Functions.getPointOnCircle(edge.Target.Location, control2, 25);

            g.DrawBezier(isCurrent ? CurrentEdgePen : EdgePen, newSource, control1, control2, newTarget);
            g.DrawString(edge.Weight.ToString(), SystemFonts.DefaultFont, Brushes.Black, weigth, WeightStringFormat);
        }
        public static void DrawEdge(this Graphics g, Edge edge)
        {
            PointF[] controlPoints = Functions.DivideLine(edge.Source.Location, edge.Target.Location, 3);
            PointF[] centerPoints = Functions.DivideLine(edge.Source.Location, edge.Target.Location, 2);
            PointF control1 = Functions.Prependicular(edge.Source.Location, edge.Target.Location, controlPoints[0], 10);
            PointF control2 = Functions.Prependicular(edge.Source.Location, edge.Target.Location, controlPoints[1], 10);
            PointF weigth = Functions.Prependicular(edge.Source.Location, edge.Target.Location, centerPoints[0], 22);
            PointF newSource = Functions.getPointOnCircle(edge.Source.Location, control1, 25);
            PointF newTarget = Functions.getPointOnCircle(edge.Target.Location, control2, 25);

            g.DrawBezier(EdgePen, newSource, control1, control2, newTarget);
            g.DrawString(edge.Weight.ToString(), SystemFonts.DefaultFont, Brushes.Black, weigth, WeightStringFormat);
        }
    }
}
