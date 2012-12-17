using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
//using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Redactor_IP
{
    public partial class MainScreen : Form
    {
        public Shape tempShape;
        List<Shape> Shapes = new List<Shape>();
        Pen pMain = new Pen(Color.Blue);


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
            tempShape = new Cross(e.X, e.Y);
            AddShape(tempShape);
            tempShape = null;
            //hapeStart = false;
            this.Refresh();
        }

        private void MainScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape kr in this.Shapes)
                kr.DrawWith(e.Graphics, pMain);
        }
    }
}