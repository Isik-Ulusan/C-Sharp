using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        private Table table1 = new Table("Table 1");
        private Table table2 = new Table("Table 2");
        private Table table3 = new Table("Table 3");
        private Table table4 = new Table("Table 4");
        private Table table5 = new Table("Table 5");
        private Table table6 = new Table("Table 6");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table1.Visible = !table1.Visible;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            table2.Visible = !table2.Visible;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table3.Visible = !table3.Visible;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            table4.Visible = !table4.Visible;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            table5.Visible = !table5.Visible;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            table6.Visible = !table6.Visible;

        }

        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double total = table1.Total + table2.Total + table3.Total + table4.Total + table5.Total + table6.Total;
            MessageBox.Show("Total Revenue: " + total);
        }

        private void sumOfTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double total = table1.Total + table2.Total + table3.Total + table4.Total + table5.Total + table6.Total;
            MessageBox.Show("Total Tips: " + total * 0.25);
        }
    }
}
