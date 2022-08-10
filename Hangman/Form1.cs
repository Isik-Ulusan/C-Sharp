using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] arr = { "DICTIONARY", "COMPUTER", "MATERIAL", "ILLUSIONIST", "RHETORIC",
                                 "CRIMINAL", "COMMONPLACE", "MYTHICAL", "PROPERTY", "CONDITIONER",
                                 "KEYBOARD", "PHOTOGRAPHY", "APARTMENT", "PRACTITIONER", "DILAPIDATED"};
        private string selected_word;
        private char[] chars;
        private char[] yldz;
        private int miss = 0;
        private int wins = 0;
        private int losses = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi = random.Next(arr.Length);

            selected_word = arr[sayi];
            label1.Text = yildiz();
            yldz = yildiz().ToCharArray();

            chars = selected_word.ToCharArray();
            button1.Text = "New Word";

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;

            miss = 0;
            pictureBox1.Image = global::Hangman.Properties.Resources.stage0;
        }

        private string yildiz()
        {
            string yldz = "";
            for (int i=0; i<selected_word.Length; i++)
            {
                yldz += "*";
            }
            return yldz;
        }

        private void misses()
        {
            if (miss != 7)
            {
                miss++;
                switch (miss)
                {
                    case 0:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage0;
                        break;
                    case 1:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage1;
                        break;
                    case 2:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage2;
                        break;
                    case 3:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage3;
                        break;
                    case 4:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage4;
                        break;
                    case 5:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage5;
                        break;
                    case 6:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage6;
                        break;
                    case 7:
                        pictureBox1.Image = global::Hangman.Properties.Resources.stage7;
                        break;
                }
            }
            else
            {
                pictureBox1.Image = global::Hangman.Properties.Resources.stage8;
                button1.Text = "GAME OVER";

                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonE.Enabled = false;
                buttonF.Enabled = false;
                buttonG.Enabled = false;
                buttonH.Enabled = false;
                buttonI.Enabled = false;
                buttonJ.Enabled = false;
                buttonK.Enabled = false;
                buttonL.Enabled = false;
                buttonM.Enabled = false;
                buttonN.Enabled = false;
                buttonO.Enabled = false;
                buttonP.Enabled = false;
                buttonQ.Enabled = false;
                buttonR.Enabled = false;
                buttonS.Enabled = false;
                buttonT.Enabled = false;
                buttonU.Enabled = false;
                buttonV.Enabled = false;
                buttonW.Enabled = false;
                buttonX.Enabled = false;
                buttonY.Enabled = false;
                buttonZ.Enabled = false;

                losses++;
                label3.Text = "Losses: " + losses;
            }
        }

        private void checkWin()
        {
            Boolean win = true;
            for (int i = 0; i < yldz.Length; i++)
            {
                if (yldz[i] == '*')
                {
                    win = false;
                }
            }
            if (win == true)
            {
                button1.Text = "YOU WIN";

                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonE.Enabled = false;
                buttonF.Enabled = false;
                buttonG.Enabled = false;
                buttonH.Enabled = false;
                buttonI.Enabled = false;
                buttonJ.Enabled = false;
                buttonK.Enabled = false;
                buttonL.Enabled = false;
                buttonM.Enabled = false;
                buttonN.Enabled = false;
                buttonO.Enabled = false;
                buttonP.Enabled = false;
                buttonQ.Enabled = false;
                buttonR.Enabled = false;
                buttonS.Enabled = false;
                buttonT.Enabled = false;
                buttonU.Enabled = false;
                buttonV.Enabled = false;
                buttonW.Enabled = false;
                buttonX.Enabled = false;
                buttonY.Enabled = false;
                buttonZ.Enabled = false;

                wins++;
                label2.Text = "Wins: " + wins;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i=0; i<chars.Length; i++)
            {
                if (chars[i] == 'A')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'A';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if(found == false)
            {
                misses();
            }
            buttonA.Enabled = false;
            checkWin();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'B')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'B';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonB.Enabled = false;
            checkWin();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'C')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'C';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonC.Enabled = false;
            checkWin();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'D')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'D';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonD.Enabled = false;
            checkWin();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'E')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'E';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonE.Enabled = false;
            checkWin();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'F')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'F';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonF.Enabled = false;
            checkWin();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'G')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'G';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonG.Enabled = false;
            checkWin();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'H')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'H';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonH.Enabled = false;
            checkWin();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'I')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'I';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonI.Enabled = false;
            checkWin();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'J')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'J';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonJ.Enabled = false;
            checkWin();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'K')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'K';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonK.Enabled = false;
            checkWin();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'L')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'L';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonL.Enabled = false;
            checkWin();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'M')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'M';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonM.Enabled = false;
            checkWin();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'N')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'N';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonN.Enabled = false;
            checkWin();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'O')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'O';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonO.Enabled = false;
            checkWin();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'P')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'P';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonP.Enabled = false;
            checkWin();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'Q')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'Q';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonQ.Enabled = false;
            checkWin();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'R')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'R';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonR.Enabled = false;
            checkWin();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'S')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'S';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonS.Enabled = false;
            checkWin();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'T')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'T';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonT.Enabled = false;
            checkWin();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'U')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'U';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonU.Enabled = false;
            checkWin();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'V')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'V';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonV.Enabled = false;
            checkWin();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'W')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'W';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonW.Enabled = false;
            checkWin();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'X')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'X';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonX.Enabled = false;
            checkWin();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'Y')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'Y';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonY.Enabled = false;
            checkWin();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'Z')
                {
                    found = true;
                    label1.Text = "";
                    yldz[i] = 'Z';
                    foreach (char c in yldz)
                    {
                        label1.Text += c;
                    }
                }
            }
            if (found == false)
            {
                misses();
            }
            buttonZ.Enabled = false;
            checkWin();
        }
    }
}
