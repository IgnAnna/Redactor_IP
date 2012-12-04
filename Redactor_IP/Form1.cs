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
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = e.X + ";" + e.Y;
        }

       

       

        

       

    }
}