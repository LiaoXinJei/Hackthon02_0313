using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telecommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var list = CreateList();
            var result = list.Min(x=>x.Sum);
            label2.Text = "";
            foreach (var i in list)
            {
                if (i.Sum == result)
                    label2.Text += $"最省的電信為{i.Communictation},每月應繳{i.Sum}\n";
            }
        }

        private List<Rates> CreateList()
        {
            List<Rates> list = new List<Rates>();
            list.Add(new Rates { Communictation = "中華電信", Sum = 350 + 4 * (int)numericUpDown1.Value });
            list.Add(new Rates { Communictation = "遠傳電信", Sum = 400 + 3 * (int)numericUpDown1.Value });
            list.Add(new Rates { Communictation = "台哥大", Sum = 500 + 2 * (int)numericUpDown1.Value });
            return list;
        }
    }
}
