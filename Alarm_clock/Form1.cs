using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SoundPlayer player = new SoundPlayer();

        private void button1_Click(object sender, System.EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DateTime alarm = new DateTime(datetime.Year, datetime.Month, datetime.Day, Convert.ToInt16(comboBox1.SelectedItem), Convert.ToInt16(comboBox2.SelectedItem), Convert.ToInt16(comboBox3.SelectedItem));

            if (datetime.Hour == alarm.Hour && datetime.Minute == alarm.Minute && datetime.Second == alarm.Second)
            { 
                timer1.Stop();
                player.Stream = Alarm_clock.Properties.Resources.alarm_clock_sound;
                player.PlayLooping();
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
