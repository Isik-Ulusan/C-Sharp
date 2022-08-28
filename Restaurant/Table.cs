using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Table : Form
    {
        private string str = "";
        private double total = 0;
        public Table(string str)
        {
            this.str = str;
            InitializeComponent();
        }

        public double Total{ 
            get { return total; } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Orders.Items.Add(comboBox1.SelectedItem);
            }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    total += 12;
                    break;
                case 1:
                    total += 20;
                    break;
                case 2:
                    total += 5;
                    break;
                case 3:
                    total += 2;
                    break;
                case 4:
                    total += 12;
                    break;
                case 5:
                    total += 5;
                    break;
                case 6:
                    total += 15;
                    break;
            }
            label3.Text = "Total: " + total;
            label4.Text = "Tip: " + total * 0.15;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Orders.Text)
            {
                case "Hamburger | 12 USD":
                    total -= 12;
                    break;
                case "Steak | 20 USD":
                    total -= 20;
                    break;
                case "Spaghetti | 5 USD":
                    total -= 5;
                    break;
                case "Hot Dog | 2 USD":
                    total -= 2;
                    break;
                case "Pizza | 12 USD":
                    total -= 12;
                    break;
                case "Noodle | 5 USD":
                    total -= 5;
                    break;
                case "Sushi | 15 USD":
                    total -= 15;
                    break;
            }
            label3.Text = "Total: " + total;
            label4.Text = "Tip: " + total * 0.15;

            Orders.Items.Remove(Orders.SelectedItem);
            button1.Enabled = false;


        }

        private void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Orders.SelectedItem != null)
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            button1.Enabled = false;
            label3.Text = "Total:";
            label4.Text = "Tip:";
            Orders.Items.Clear();
            button2.Enabled = false;
            total = 0;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
