using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Redactor_IP
{
    public abstract class Shape
    {
        public abstract void DrawWith(Graphics e, Pen p);
    }
    public class Cross : Shape
    {
        public int X;
        public int Y;
        public string line;


        public Cross(int _X, int _Y)
        {
            this.X = _X; this.Y = _Y;
        }
        public Cross(StreamReader sr)
        {
            line = sr.ReadLine();
            string[] foo = line.Split(' ');
            X = Convert.ToInt32(foo[0]);
            Y = Convert.ToInt32(foo[1]);
        }

        public override void DrawWith(Graphics g, Pen p)
        {
            g.DrawLine(p, this.X - 3, this.Y - 3, this.X + 3, this.Y + 3);
            g.DrawLine(p, this.X + 3, this.Y - 3, this.X - 3, this.Y + 3);
        }
    }
    public class Line : Shape
    {
        Point s, f;
        public Line(Point _s, Point _f)
        {
            this.s = _s;
            this.f = _f;
        }
        public override void DrawWith(Graphics g, Pen p)
        {
            g.DrawLine(p, s, f);
        }
    }
}
