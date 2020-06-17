﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelClient.form
{
    public partial class Form_TripNote : Form
    {
        private Point formPoint = new Point();

        public Form_TripNote()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }
    }
}