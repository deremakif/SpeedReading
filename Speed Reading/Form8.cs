using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Threading;
using Timer = System.Timers.Timer;

namespace Speed_Reading
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            Btn_Play.Enabled = false;
        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form8 form8sec = new Form8();
            form8sec.Show();
            this.Hide();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Form9 form9sec = new Form9();
            form9sec.Show();
            this.Hide();

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form7 form7sec = new Form7();
            form7sec.Show();
            this.Hide();
        }


     
        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Form9 form9sec = new Form9();
                form9sec.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.Left)
            {
                Form7 form7sec = new Form7();
                form7sec.Show();
                this.Hide();
            }
        }

        

        private void Btn_Next_MouseHover(object sender, EventArgs e)
        {
            Btn_Next.BackColor = Color.Turquoise;
        }

        private void Btn_Next_MouseLeave(object sender, EventArgs e)
        {
            Btn_Next.BackColor = Form.DefaultBackColor;
        }
        private void Btn_Back_MouseHover(object sender, EventArgs e)
        {
            Btn_Back.BackColor = Color.Turquoise;
        }

        private void Btn_Back_MouseLeave(object sender, EventArgs e)
        {
            Btn_Back.BackColor = Form.DefaultBackColor;
        }

        private void Btn_Play_MouseHover(object sender, EventArgs e)
        {
            Btn_Play.BackColor = Color.Turquoise;
        }

        private void Btn_Play_MouseLeave(object sender, EventArgs e)
        {
            Btn_Play.BackColor = Form.DefaultBackColor;
        }

        private void Btn_Pause_MouseHover(object sender, EventArgs e)
        {
            Btn_Pause.BackColor = Color.Turquoise;
        }

        private void Btn_Pause_MouseLeave(object sender, EventArgs e)
        {
            Btn_Pause.BackColor = Form.DefaultBackColor;
        }

        

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox6.Left = pictureBox6.Left+10;            
            if (this.pictureBox6.Left > 950)
            {
                this.timer1.Enabled = false;
                Btn_Play.Enabled = true;

            }




        }


        private void dispatcherTimer1_Tick(object sender, EventArgs e)
        {

        }

        private void dispatcherTimer2_Tick(object sender, EventArgs e)
        {

        }


  

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

    }
}
