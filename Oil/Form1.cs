﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input input = new Input();
            input.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}
