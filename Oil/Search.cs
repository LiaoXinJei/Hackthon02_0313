using Oil.ContactModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oil
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Start = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime End = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month , dateTimePicker2.Value.Day);
            var EndAdd1 = End.AddDays(1);
            var context = new ContactsModel();
            var list = context.ContactsTable.Where(x => x.RefuilingDate >= Start).Where(x => x.RefuilingDate <= EndAdd1).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;

            double Total = 0, TotalKilometer = 0, TotalLiter = 0 ;
            for(var i=0; i< list.Count;i++)
            {
                TotalKilometer += list[i].Kilometer;
                TotalLiter += list[i].Liter;
            }

            Total = TotalKilometer / TotalLiter;
            label3.Text = $"每公升的平均油耗(公里/公升)：  {Total}";
        }
    }
}
