using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        private string[] meds =
        {
            "Parol", "Ibuprofen", "Synthriod", "Crestor", "Ventolin HFA", "Nexium", "Advair Diskus",
            "Lantus Solostar", "Vyvanse", "Lyrica", "Spiriva", "Januvia", "Humira", "Abilify",
            "Sovaldi", "Enbrel", "Harvoni", "Keytruda", "Remicade", "Revlimid"
        };
        private int[] prices = { 20, 22, 25, 36, 23, 49, 85, 76, 29, 34, 85, 68, 72, 34, 95, 15, 23, 51, 23, 67 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Do you have a prescription", "New Patient", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                button1.Enabled = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                Prescription.Visible = true;
                NotAvailable.Visible = true;
                Available.Visible = true;

            }
            else if (msg == DialogResult.No)
            {
                MessageBox.Show("Please get a prescription in order to buy drugs", "Prescription Needed");
            }
            button2.Text = "Add";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Int32> avaPrc = new List<Int32>();

            switch (button2.Text)
            {
                case "Add":
                    StringReader rdr = new StringReader(Properties.Resources.Prescription);
                    string str;
                    while ((str = rdr.ReadLine()) != null)
                    {
                        Prescription.Items.Add(str);
                    }
                    button2.Text = "Check";
                    break;

                case "Check":
                    bool notavailable = true;
                    for (int i = 0; i < Prescription.Items.Count; i++)
                    {
                        int j = 0;
                        while (j < meds.Length && notavailable == true)
                        {
                            if (meds[j] == (string) Prescription.Items[i])
                            {
                                notavailable = false;
                            }
                            j++;

                        }

                        if (notavailable == false)
                        {
                            Available.Items.Add(Prescription.Items[i]);
                            avaPrc.Add(prices[j-1]);
                        }
                        else
                        {
                            NotAvailable.Items.Add(Prescription.Items[i]);
                        }
                        notavailable = true;
                    }
                    label4.Text = "Total: " + avaPrc.Sum() + " USD";
                    button2.Text = "Ask for unavailable";
                    break;

                case "Ask for unavailable":
                    DialogResult msg2 = MessageBox.Show("Do you want to get them sent from another pharmacy?", "Unavailable Medicine", MessageBoxButtons.YesNo);
                    if (msg2 == DialogResult.Yes)
                    {
                        MessageBox.Show("The unavailable ones have been ordered", "Order from Another Pharmacy");
                    }
                    else if (msg2 == DialogResult.No)
                    {
                        MessageBox.Show("Order Declined", "Order from Another Pharmacy");
                    }
                    button2.Text = "Order Available";
                    break;
                case "Order Available":
                    MessageBox.Show("Order Complete", "Checkout");
                    button1.Enabled = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button2.Visible = false;
                    Prescription.Visible = false;
                    NotAvailable.Visible = false;
                    Available.Visible = false;

                    Available.Items.Clear();
                    NotAvailable.Items.Clear();
                    Prescription.Items.Clear();

                    button2.Text = "Add";
                    label4.Text = "Total:";
                    break;
            }
        }
    }
}
