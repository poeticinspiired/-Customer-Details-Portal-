// Abdi Sidnoor, 000776285
//I, Abdi Sidnoor, 000776285 affirm that this work is my original creation.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Assignment5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWind_Assignment5DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northWind_Assignment5DataSet.Orders);
            // TODO: This line of code loads data into the 'northWind_Assignment5DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northWind_Assignment5DataSet.Customers);

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
