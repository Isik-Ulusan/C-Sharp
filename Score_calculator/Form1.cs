using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double enscore, spscore, mascore, phscore, biscore, chscore, hiscore, gescore;

            enscore = Convert.ToDouble(en_t.Text) - Convert.ToDouble(en_f.Text) / 3;
            en_s.Text = Convert.ToString(enscore);

            spscore = Convert.ToDouble(sp_t.Text) - Convert.ToDouble(sp_f.Text) / 3;
            sp_s.Text = Convert.ToString(spscore);

            mascore = Convert.ToDouble(ma_t.Text) - Convert.ToDouble(ma_f.Text) / 3;
            ma_s.Text = Convert.ToString(mascore);

            phscore = Convert.ToDouble(ph_t.Text) - Convert.ToDouble(ph_f.Text) / 3;
            ph_s.Text = Convert.ToString(phscore);

            biscore = Convert.ToDouble(bi_t.Text) - Convert.ToDouble(bi_f.Text) / 3;
            bi_s.Text = Convert.ToString(biscore);

            chscore = Convert.ToDouble(ch_t.Text) - Convert.ToDouble(ch_f.Text) / 3;
            ch_s.Text = Convert.ToString(chscore);

            hiscore = Convert.ToDouble(hi_t.Text) - Convert.ToDouble(hi_f.Text) / 3;
            hi_s.Text = Convert.ToString(hiscore);

            gescore = Convert.ToDouble(ge_t.Text) - Convert.ToDouble(ge_f.Text) / 3;
            ge_s.Text = Convert.ToString(gescore);

            double gpa;

            gpa = enscore + spscore + mascore + phscore + biscore + chscore + hiscore + gescore;

            answer.Text = "GPA: " + gpa;


        }
    }
}
