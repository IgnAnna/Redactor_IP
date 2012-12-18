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
    public partial class MainScreen : Form
    {
        public Shape tempShape;
        List<Shape> Shapes = new List<Shape>();
        Pen pMain = new Pen(Color.Blue);
        Pen pTemp = new Pen(Color.Purple);
        Pen pch = new Pen(Color.Blue, 2);
        bool IsShapeStart = false;
        Point Shapestart;
        string file = " ";
        Point koor = new Point();



        public MainScreen()
        {
            InitializeComponent();
        }
        private void AddShape(Shape shape)
        {
            if (shape != null) Shapes.Add(shape);

        }

        private void MainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = e.X + ";" + e.Y;
           
        }

        private void MainScreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (Cross.Checked)
            {
                tempShape = new Cross(e.X, e.Y);
                AddShape(tempShape);
                tempShape = null;
                this.Refresh();
                ShapesList.Items.Add("Cross" + Convert.ToString(e.Location)); 
            }
            if (Line.Checked)
            {
                IsShapeStart = !IsShapeStart;
                if (IsShapeStart)
                {
                    Shapestart = e.Location;

                }
                else
                {
                    ShapesList.Items.Add("Line" + " " + Shapestart + " " + e.Location);
                    AddShape(new Line(Shapestart, e.Location)); 
                }
            }
            this.Refresh();
        }

        private void MainScreen_Paint(object sender, PaintEventArgs e)
        {
            if (tempShape != null)
            {
                tempShape.DrawWith(e.Graphics, pTemp);
            }
            foreach (int i in ShapesList.SelectedIndices)
            {
                Shapes[i].DrawWith(e.Graphics, pch);
            }
            foreach (Shape kr in this.Shapes)
            { 
                kr.DrawWith(e.Graphics, pMain); 
            }
          
        }

        private void Cross_Line_Changed(object sender, EventArgs e)
        {
            IsShapeStart = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string type = sr.ReadLine();
                    switch (type)
                    {
                        case "Cross":
                            Shapes.Add(new Cross(sr));
                            break;
                        case "Line":
                            Shapes.Add(new Line(sr));
                            break;
                    }
                }
                this.Refresh();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = saveFileDialog1.FileName; ;
                StreamWriter sw = new StreamWriter(file);
                foreach (Shape p in this.Shapes)
                {
                    p.SaveTo(sw);
                }
                sw.Close();
            }
        }

        private void MainScreen_MouseMove(object sender, MouseEventArgs e)
        {
            Point TempPoint = e.Location;
            this.Refresh();
            if (Cross.Checked)
            {
                tempShape = new Cross(e.X, e.Y);
                this.Refresh();
            }
            else if (Line.Checked)
            {
                if (!IsShapeStart) return;
                tempShape = new Line(Shapestart, TempPoint);
                this.Refresh();
            }

        }

        private void ShapesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            while (ShapesList.SelectedIndices.Count > 0)
            {
                Shapes.RemoveAt(ShapesList.SelectedIndices[0]);
                ShapesList.Items.RemoveAt(ShapesList.SelectedIndices[0]);
            }
            this.Refresh();
        }
    }
}