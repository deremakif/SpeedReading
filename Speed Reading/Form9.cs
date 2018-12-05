using DevExpress.XtraEditors;
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
            pictureBox1.Location = new Point(pictureBox5.Left+100, pictureBox5.Top+100);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(pictureBox5.Left + 800, pictureBox5.Top + 100);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(pictureBox5.Left + 100, pictureBox5.Top + 200);        
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(pictureBox5.Left + 800, pictureBox5.Top + 200);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(pictureBox5.Left + 100, pictureBox5.Top +300);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(pictureBox5.Left + 800, pictureBox5.Top + 300);
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

        private void Form9_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {


                pictureBox1.Left = pictureBox5.Left + 100;
                pictureBox1.Top = pictureBox5.Top + 100;

                if (item is SimpleButton)
                {
                    item.Top = Size.Height - 120;
                }
            }

        }

        private void Form9_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                pictureBox5.Left = Size.Width - 1300;
                pictureBox1.Left = Size.Width - 1300;
                if (item is SimpleButton)
                {
                    item.Top = Size.Height - 120;
                }
            }
        }
    }
}
