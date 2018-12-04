using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Speed_Reading
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }


        public void play()
        {
            pictureBox1.Location = new Point(720, 131);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(220, 200);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(720, 200);        
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(220, 270);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(720, 270);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(220, 370);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();


        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            play();



        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {

        }
    }
}
