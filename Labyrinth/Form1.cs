using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean won = false;

        private void pictureBox96_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (won && e.KeyChar == 'r')
            {
                label1.BackColor = Color.MistyRose;
                label1.ForeColor = Color.DarkRed;
                label1.Text = "Game Over";

                label2.BackColor = Color.MistyRose;
                label2.ForeColor = Color.DarkRed;
                won = false;
            }
            if ((label2.Visible == true) && (e.KeyChar == 'r'))
            {
                Point p = pictureBoxStart.Location;
                p.Offset(pictureBoxStart.Width / 2, pictureBoxStart.Height / 2);
                Cursor.Position = PointToScreen(p);
                label1.Visible = false;
                label2.Visible = false;
            }
        }

        private void pictureBoxFinish_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;

            label2.BackColor = Color.LightGreen;
            label2.ForeColor = Color.DarkGreen;

            label1.Text = "You Won";
            label1.BackColor = Color.LightGreen;
            label1.ForeColor = Color.DarkGreen;
            won = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point p = pictureBoxStart.Location;
            p.Offset(pictureBoxStart.Width / 2, pictureBoxStart.Height / 2);
            Cursor.Position = PointToScreen(p);
        }
    }
}
