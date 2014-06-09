using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphEditor
{
    public static class Functions
    {
        public static string GetAutomaticLabel(int index)
        {
            int quotient = (index) / 26;
            if (quotient > 0)
            {
                return GetAutomaticLabel(quotient - 1) + Convert.ToString((char)((index % 26) + 65));
            }
            else
            {
                return Convert.ToString((char)((index % 26) + 65));
            }
        }
        public static Double DegreesToRadians(Double degrees)
        {
            return degrees * Math.PI / 180;
        }
        public static Double RadiansToDegrees(Double radians)
        {
            return radians * 180 / Math.PI;
        }
        public static Double LineAngleInRadians(PointF p1, PointF p2)
        {
            return Math.Atan2(p2.X - p1.X, p2.Y - p1.Y);
        }
        public static Double LineAngleInDegrees(PointF p1, PointF p2)
        {
            return RadiansToDegrees(LineAngleInRadians(p1, p2));
        }
        public static PointF[] DivideLine(PointF p1, PointF p2, Int32 pieces)
        {
            Int32 size = pieces - 1;
            PointF[] points = new PointF[size];
            for (int i = 0; i < size; i++)
            {
                Int32 piece = i + 1;
                points[i] = new PointF(
                    p1.X + ((p2.X - p1.X) * piece) / pieces,
                    p1.Y + ((p2.Y - p1.Y) * piece) / pieces
                );
            }
            return points;
        }
        public static Double LineLength(PointF p1, PointF p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }

        public static Double getAngle(PointF p1, PointF p2)
        {
            return (Math.Atan2(p1.X - p2.X, p1.Y - p2.Y) * 180 / Math.PI) + 90;
        }

        public static PointF Prependicular(PointF p1, PointF p2, PointF center, Int32 length)
        {
            double x = Math.Cos(2 * Math.PI * (LineAngleInDegrees(p1, p2) + 180) / 360) * length + center.X;
            double y = -Math.Sin(2 * Math.PI * (LineAngleInDegrees(p1, p2) + 180) / 360) * length + center.Y;
            return new PointF((int)x, (int)y);
        }
        public static PointF getPointOnCircle(PointF p1, PointF p2, Int32 radius)
        {
            PointF Pointref = PointF.Subtract(p2, new SizeF(p1));
            double degrees = Math.Atan2(Pointref.Y, Pointref.X);
            double cosx1 = Math.Cos(degrees);
            double siny1 = Math.Sin(degrees);

            double cosx2 = Math.Cos(degrees + Math.PI);
            double siny2 = Math.Sin(degrees + Math.PI);

            return new PointF((int)(cosx1 * (float)(radius) + (float)p1.X), (int)(siny1 * (float)(radius) + (float)p1.Y));
        }
        public static Boolean IsPointInsideCircle(PointF p, PointF center, Single radius)
        {

            return Math.Pow(p.X - center.X, 2) + Math.Pow(p.Y - center.Y, 2) <= Math.Pow(radius, 2);
        
        }
    }
}
