using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Reading
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Form8 form8sec = new Form8();
            form8sec.Show();
            this.Hide();
        }
        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Form8 form8sec = new Form8();
                form8sec.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.Left)
            {
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Show();
            this.Hide();
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
        public void Delayed(int delay, Action action)
        {
            Timer timer = new Timer();
            timer.Interval = delay;
            timer.Tick += (s, e) => {
                action();
                timer.Stop();
            };
            timer.Start();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            int i = 1;
            int t = 0;
            while (i < 4)
            {
                Delayed(1000 + t, () => pictureBox1.Visible = true);
                Delayed(1500 + t, () => pictureBox1.Visible = false);
                Delayed(1500 + t, () => pictureBox2.Visible = true);
                Delayed(2000 + t, () => pictureBox2.Visible = false);
                Delayed(2000 + t, () => pictureBox3.Visible = true);
                Delayed(2500 + t, () => pictureBox3.Visible = false);
                Delayed(2500 + t, () => pictureBox4.Visible = true);
                Delayed(3000 + t, () => pictureBox4.Visible = false);
                Delayed(3000 + t, () => pictureBox5.Visible = true);
                Delayed(3500 + t, () => pictureBox5.Visible = false);
                Delayed(3500 + t, () => pictureBox6.Visible = true);
                Delayed(4000 + t, () => pictureBox6.Visible = false);

                t = t + 3000;
                i++;
            }
            i = 1;
            while (i < 6)
            {
                Delayed(1000 + t, () => pictureBox7.Visible = true);
                Delayed(1500 + t, () => pictureBox7.Visible = false);
                Delayed(1500 + t, () => pictureBox8.Visible = true);
                Delayed(2000 + t, () => pictureBox8.Visible = false);
                Delayed(2000 + t, () => pictureBox9.Visible = true);
                Delayed(2500 + t, () => pictureBox9.Visible = false);
                Delayed(2500 + t, () => pictureBox10.Visible = true);
                Delayed(3000 + t, () => pictureBox10.Visible = false);
                Delayed(3000 + t, () => pictureBox11.Visible = true);
                Delayed(3500 + t, () => pictureBox11.Visible = false);
                Delayed(3500 + t, () => pictureBox12.Visible = true);
                Delayed(4000 + t, () => pictureBox12.Visible = false);

                t = t + 3000;
                i++;
            }




        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form7 form7sec = new Form7();
            form7sec.Show();
            this.Hide();
        }
    }
}
