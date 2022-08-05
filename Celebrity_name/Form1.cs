using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celebrity_name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtn1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Name: Chuck Schuldiner";
            label2.Text = "Band: Death";
        }

        private void rdbtn2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Name: Tomas Haake";
            label2.Text = "Band: Meshuggah";
        }

        private void rdbtn3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Name: Tosin Abasi";
            label2.Text = "Band: Animals as Leaders";
        }
    }
}
