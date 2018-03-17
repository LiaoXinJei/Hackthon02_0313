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
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.ThousandsSeparator = true;
            numericUpDown1.Maximum = 2000;
            numericUpDown2.Maximum = 2000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable()
            {
                RefuilingDate = dateTimePicker1.Value,
                Liter = (double)numericUpDown1.Value,
                Kilometer = (double)numericUpDown2.Value
            };
            try
            {
                ContactsModel model = new ContactsModel();
                model.ContactsTable.Add(data);
                model.SaveChanges();
                MessageBox.Show("存檔完成");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("發生錯誤");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
