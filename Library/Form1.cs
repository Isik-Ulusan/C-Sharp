using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> list = new List<string>();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                removeToolStripMenuItem.Enabled = true;
                lendToolStripMenuItem.Enabled = true;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                panel1.Visible = false;
                textBox1.Text = "";
            }
        }

        private void lendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null && textBox2.Text != "")
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                panel2.Visible = false;
                list.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                label6.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label6.Text = "Name:\n" + list[listBox2.SelectedIndex];
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                list.Remove(list[listBox2.SelectedIndex]);
                listBox3.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                checkBox1.Checked = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                label6.Text = "Name:";
                label6.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                list.Remove(list[listBox2.SelectedIndex]);
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                checkBox2.Checked = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                label6.Text = "Name:";
                label6.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(listBox3.SelectedItem);
                listBox3.Items.Remove(listBox3.SelectedItem);
                checkBox3.Checked = false;
                checkBox3.Visible = false;
                DialogResult = MessageBox.Show("Late fee: 500 USD");
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                checkBox3.Visible = true;
            }
        }
    }
}
