﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        screen.UserControl9 UserControl9 = new screen.UserControl9();
        screen.UserControl1 UserControl1 = new screen.UserControl1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(UserControl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(UserControl9);
        }
    }
}