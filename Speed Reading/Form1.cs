﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Speed_Reading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Form10 form10sec = new Form10();
            form10sec.Show();
            this.Hide();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                Form10 form10sec = new Form10();
                form10sec.Show();
                this.Hide();
            }

        }
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
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
            Btn_Back.BackColor = Color.Red;
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
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            Btn_Play.Enabled = false;
            Delayed(10, () => label1.Visible = true);
            Delayed(2000, () => label2.Visible = true);
            Delayed(4000, () => label3.Visible = true);
            Delayed(6000, () => label6.Visible = true);
            Delayed(8000, () => label7.Visible = true);
            Delayed(10000, () => label5.Visible = true);
            Delayed(10000, () => label8.Visible = true);
            Delayed(11000, () => Btn_Play.Enabled = true);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            Form8 form8sec = new Form8();
            form8sec.Show();
            this.Hide();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

            Form9 form9sec = new Form9();
            form9sec.Show();
            this.Hide();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Form13 form13sec = new Form13();
            form13sec.Show();
            this.Hide();
        }

        void SetComponents()
        {
            foreach (Control item in Controls)
            {
                //if (item is Button)
                //{
                //    item.Width = Size.Width / 4 - 16;
                //    item.Height = Size.Height / 4;
                //    item.Font = new Font(Font.FontFamily, item.Height / 5);
                //}

                //button1.Left = 10;
                //button1.Top = 10;

                //button2.Left = button1.Right + 10;
                //button2.Top = button1.Top;

                if (item is SimpleButton)
                {
                    //item.Width = Size.Width / 4 - 16;
                    //item.Height = Size.Height / 4;
                    //item.Font = new Font(Font.FontFamily, item.Height / 5);
                    item.Top = Size.Height - 120;
                    //item.Left = 10;
                }


                //button1.Left = 10;
                //button1.Top = 10;

                //button2.Left = button1.Right + 10;
                //button2.Top = button1.Top;
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            SetComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                label4.Left = Size.Width - 1300; 
                if (item is SimpleButton)
                {
                    item.Top = Size.Height - 120;
                }
            }


        }
    }
}
