﻿using DevExpress.XtraEditors;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Show();
            this.Hide();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form11 form11sec = new Form11();
            form11sec.Show();
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
            timer.Tick += (s, e) =>
            {
                action();
                timer.Stop();
            };
            timer.Start();
        }
        
        private void Btn_Play_Click(object sender, EventArgs e)
        {
            Btn_Play.Enabled = false;

            if (radioButton1.Checked == true)
            {
                int i = 1;
                int t = 0;
                while (i < 2 )
                {
                    Delayed(1000 + t, () => pBox1.Visible = true);
                    Delayed(1500 + t, () => pBox1.Visible = false);
                    Delayed(1500 + t, () => pBox2.Visible = true);
                    Delayed(2000 + t, () => pBox2.Visible = false);
                    Delayed(2000 + t, () => pBox3.Visible = true);
                    Delayed(2500 + t, () => pBox3.Visible = false);
                    Delayed(2500 + t, () => pBox4.Visible = true);
                    Delayed(3000 + t, () => pBox4.Visible = false);
                    Delayed(3000 + t, () => pBox5.Visible = true);
                    Delayed(3500 + t, () => pBox5.Visible = false);
                    Delayed(3500 + t, () => pBox6.Visible = true);
                    Delayed(4000 + t, () => pBox6.Visible = false);
                    Delayed(4000 + t, () => pBox7.Visible = true);
                    Delayed(4500 + t, () => pBox7.Visible = false);
                    Delayed(4500 + t, () => pBox8.Visible = true);
                    Delayed(5000 + t, () => pBox8.Visible = false);
                    Delayed(5000 + t, () => pBox9.Visible = true);
                    Delayed(5500 + t, () => pBox9.Visible = false);
                    Delayed(5500 + t, () => pBox10.Visible = true);
                    Delayed(6000 + t, () => pBox10.Visible = false);
                    Delayed(6000 + t, () => pBox9.Visible = true);
                    Delayed(6500 + t, () => pBox9.Visible = false);
                    Delayed(6500 + t, () => pBox8.Visible = true);
                    Delayed(7000 + t, () => pBox8.Visible = false);
                    Delayed(7000 + t, () => pBox7.Visible = true);
                    Delayed(7500 + t, () => pBox7.Visible = false);
                    Delayed(7500 + t, () => pBox6.Visible = true);
                    Delayed(8000 + t, () => pBox6.Visible = false);
                    Delayed(8000 + t, () => pBox5.Visible = true);
                    Delayed(8500 + t, () => pBox5.Visible = false);
                    Delayed(8500 + t, () => pBox4.Visible = true);
                    Delayed(9000 + t, () => pBox4.Visible = false);
                    Delayed(9000 + t, () => pBox3.Visible = true);
                    Delayed(9500 + t, () => pBox3.Visible = false);
                    Delayed(9500 + t, () => pBox2.Visible = true);
                    Delayed(10000 + t, () => pBox2.Visible = false);

                    t = t + 9000;
                    i++;
                }

                i = 1;
                t = 9000;

                while (i < 6)
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
                    Delayed(4000 + t, () => pictureBox7.Visible = true);
                    Delayed(4500 + t, () => pictureBox7.Visible = false);
                    Delayed(4500 + t, () => pictureBox8.Visible = true);
                    Delayed(5000 + t, () => pictureBox8.Visible = false);
                    Delayed(5000 + t, () => pictureBox9.Visible = true);
                    Delayed(5500 + t, () => pictureBox9.Visible = false);
                    Delayed(5500 + t, () => pictureBox10.Visible = true);
                    Delayed(6000 + t, () => pictureBox10.Visible = false);
                    Delayed(6000 + t, () => pictureBox9.Visible = true);
                    Delayed(6500 + t, () => pictureBox9.Visible = false);
                    Delayed(6500 + t, () => pictureBox8.Visible = true);
                    Delayed(7000 + t, () => pictureBox8.Visible = false);
                    Delayed(7000 + t, () => pictureBox7.Visible = true);
                    Delayed(7500 + t, () => pictureBox7.Visible = false);
                    Delayed(7500 + t, () => pictureBox6.Visible = true);
                    Delayed(8000 + t, () => pictureBox6.Visible = false);
                    Delayed(8000 + t, () => pictureBox5.Visible = true);
                    Delayed(8500 + t, () => pictureBox5.Visible = false);
                    Delayed(8500 + t, () => pictureBox4.Visible = true);
                    Delayed(9000 + t, () => pictureBox4.Visible = false);
                    Delayed(9000 + t, () => pictureBox3.Visible = true);
                    Delayed(9500 + t, () => pictureBox3.Visible = false);
                    Delayed(9500 + t, () => pictureBox2.Visible = true);
                    Delayed(10000 + t, () => pictureBox2.Visible = false);

                    t = t + 9000;
                    i++;
                }

                Delayed(1000+t, () => Btn_Play.Enabled = true);
            }
        }
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form5 form5sec = new Form5();
            form5sec.Size = this.Size;
            form5sec.Location = new Point(this.Location.X, this.Location.Y);
            form5sec.Show();
            this.Hide();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
        }

    

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Size = this.Size;
            form1sec.Show();
            this.Hide();
        }

        private void Form5_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is SimpleButton)
                {
                    item.Top = 11*Size.Height / 13;
                    item.Height = Size.Height / 14;
                    item.Width = item.Height;
                }
                if (item is PictureBox)
                {

                    item.Height = Size.Height / 10;
                    item.Width = item.Height;
                }
                Btn_Pause.Left = Size.Width / 2;
                Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
                Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
                Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

                pBox1.Left = Size.Width / 12;
                pBox1.Top = Size.Height / 12;
                pBox2.Left = Size.Width / 12;
                pBox2.Top = 9 * Size.Height / 12;
                pBox3.Left = 3 * Size.Width / 12;
                pBox3.Top = Size.Height / 12;
                pBox4.Left = 3 * Size.Width / 12;
                pBox4.Top = 9 * Size.Height / 12;
                pBox5.Left = 5 * Size.Width / 12;
                pBox5.Top = Size.Height / 12;
                pBox6.Left = 5 * Size.Width / 12;
                pBox6.Top = 9 * Size.Height / 12;
                pBox7.Left = 7 * Size.Width / 12;
                pBox7.Top = Size.Height / 12;
                pBox8.Left = 7 * Size.Width / 12;
                pBox8.Top = 9 * Size.Height / 12;
                pBox9.Left = 9 * Size.Width / 12;
                pBox9.Top = Size.Height / 12;
                pBox10.Left = 9 * Size.Width / 12;
                pBox10.Top = 9 * Size.Height / 12;

                pictureBox1.Left = Size.Width / 12;
                pictureBox1.Top = Size.Height / 12;
                pictureBox2.Left = 9 * Size.Width / 12;
                pictureBox2.Top = Size.Height / 12;
                pictureBox3.Left = Size.Width / 12;
                pictureBox3.Top = 3 * Size.Height / 12;
                pictureBox4.Left = 9 * Size.Width / 12;
                pictureBox4.Top = 3 * Size.Height / 12;
                pictureBox5.Left = Size.Width / 12;
                pictureBox5.Top = 5 * Size.Height / 12;
                pictureBox6.Left = 9 * Size.Width / 12;
                pictureBox6.Top = 5 * Size.Height / 12;
                pictureBox7.Left = Size.Width / 12;
                pictureBox7.Top = 7 * Size.Height / 12;
                pictureBox8.Left = 9 * Size.Width / 12;
                pictureBox8.Top = 7 * Size.Height / 12;
                pictureBox9.Left = Size.Width / 12;
                pictureBox9.Top = 9 * Size.Height / 12;
                pictureBox10.Left = 9 * Size.Width / 12;
                pictureBox10.Top = 9 * Size.Height / 12;

                menuStrip1.Width = Size.Width;

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is SimpleButton)
                {
                    item.Top = 11 * Size.Height / 13;
                    item.Height = Size.Height / 14;
                    item.Width = item.Height;
                }
                if (item is PictureBox)
                {
                    item.Height = Size.Height / 10;
                    item.Width = item.Height;
                }
                Btn_Pause.Left = Size.Width / 2;
                Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
                Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
                Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

                pBox1.Left = Size.Width / 12;
                pBox1.Top = Size.Height / 12;
                pBox2.Left = Size.Width / 12;
                pBox2.Top = 9 * Size.Height / 12;
                pBox3.Left = 3 * Size.Width / 12;
                pBox3.Top = Size.Height / 12;
                pBox4.Left = 3 * Size.Width / 12;
                pBox4.Top = 9 * Size.Height / 12;
                pBox5.Left = 5 * Size.Width / 12;
                pBox5.Top = Size.Height / 12;
                pBox6.Left = 5 * Size.Width / 12;
                pBox6.Top = 9 * Size.Height / 12;
                pBox7.Left = 7 * Size.Width / 12;
                pBox7.Top = Size.Height / 12;
                pBox8.Left = 7 * Size.Width / 12;
                pBox8.Top = 9 * Size.Height / 12;
                pBox9.Left = 9 * Size.Width / 12;
                pBox9.Top = Size.Height / 12;
                pBox10.Left = 9 * Size.Width / 12;
                pBox10.Top = 9 * Size.Height / 12;

                pictureBox1.Left = Size.Width / 12;
                pictureBox1.Top = Size.Height / 12;
                pictureBox2.Left = 9 * Size.Width / 12;
                pictureBox2.Top = Size.Height / 12;
                pictureBox3.Left = Size.Width / 12;
                pictureBox3.Top = 3*Size.Height / 12;
                pictureBox4.Left = 9 * Size.Width / 12;
                pictureBox4.Top = 3 * Size.Height / 12;
                pictureBox5.Left = Size.Width / 12;
                pictureBox5.Top = 5*Size.Height / 12;
                pictureBox6.Left = 9 * Size.Width / 12;
                pictureBox6.Top = 5 * Size.Height / 12;
                pictureBox7.Left = Size.Width / 12;
                pictureBox7.Top = 7*Size.Height / 12;
                pictureBox8.Left = 9 * Size.Width / 12;
                pictureBox8.Top = 7 * Size.Height / 12;
                pictureBox9.Left = Size.Width / 12;
                pictureBox9.Top = 9 * Size.Height / 12;
                pictureBox10.Left = 9 * Size.Width / 12;
                pictureBox10.Top = 9 * Size.Height / 12;

                menuStrip1.Width = Size.Width;
            }
        }
    }
}
