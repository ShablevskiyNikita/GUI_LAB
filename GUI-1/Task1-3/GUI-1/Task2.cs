﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0),new Point(0, this.Height),new Point(this.Width, 0) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
