using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementary_colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Color p;
        private Boolean locked = false;
        private Point pos;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap map = new Bitmap(pictureBox1.Image);
            pos = Cursor.Position;
            if (!locked)
            {
                pos = pictureBox1.PointToClient(pos);
                if (pos.X < map.Width && pos.Y < map.Height && pos.X > 0 && pos.Y > 0)
                {
                    p = map.GetPixel(pos.X, pos.Y);
                }
                label1.BackColor = p;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            locked = !locked;
            Color c = new Color();
            int r = Color.White.R;
            r -= p.R;
            int g = Color.White.G;
            g -= p.G;
            int b = Color.White.B;
            b -= p.B;
            int a = Color.White.A;
            a -= p.A;

            c = Color.FromArgb(255, r, g, b);
            label4.BackColor = c;
        }
    }
}
