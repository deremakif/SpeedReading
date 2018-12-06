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
            form10sec.Location = new Point(this.Location.X, this.Location.Y);
            form10sec.Size = this.Size;
            form10sec.Show();
            this.Hide();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Location = new Point(this.Location.X, this.Location.Y);
            form3sec.Size = this.Size;
            form3sec.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form5 form5sec = new Form5();
            form5sec.Location = new Point(this.Location.X, this.Location.Y);
            form5sec.Size = this.Size;
            form5sec.Show();
            this.Hide();
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            Form8 form8sec = new Form8();
            form8sec.Location = new Point(this.Location.X, this.Location.Y);
            form8sec.Size = this.Size;
            form8sec.Show();
            this.Hide();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Form14 form14sec = new Form14();
            form14sec.Location = new Point(this.Location.X, this.Location.Y);
            form14sec.Size = this.Size;
            form14sec.Show();
            this.Hide();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form9 form9sec = new Form9();
            form9sec.Location = new Point(this.Location.X, this.Location.Y);
            form9sec.Size = this.Size;
            form9sec.Show();
            this.Hide();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Form13 form13sec = new Form13();
            form13sec.Location = new Point(this.Location.X, this.Location.Y);
            form13sec.Size = this.Size;
            form13sec.Show();
            this.Hide();
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form10 form10sec = new Form10();
            form10sec.Size = this.Size;
            form10sec.Location = new Point(this.Location.X, this.Location.Y);
            form10sec.Show();
            this.Hide();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                Form10 form10sec = new Form10();
                form10sec.Location = new Point(this.Location.X, this.Location.Y);
                form10sec.Size = this.Size;
                form10sec.Show();
                this.Hide();
            }

        }
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Location = new Point(this.Location.X, this.Location.Y);
            form1sec.Size = this.Size;
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

            Delayed(11000, () => Btn_Play.Enabled = true);
        }



        void SetComponents()
        {
            foreach (Control item in Controls)
            {
                menuStrip1.Width = Size.Width;

                Btn_Pause.Left = Size.Width / 2;
                Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
                Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
                Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

                if (item is SimpleButton)
                {
                    item.Top = 11 * Size.Height / 13;
                    item.Height = Size.Height / 14;
                    item.Width = item.Height;
                }

                if (item is Label)
                {
                    item.Left = Size.Width / 13;
                    item.Font = new Font("Arial", Size.Width / 80, FontStyle.Bold);
                }

                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }
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
                menuStrip1.Width = Size.Width;
                Btn_Pause.Left = Size.Width / 2;
                Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
                Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
                Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

                if (item is SimpleButton)
                {
                    item.Top = 11 * Size.Height / 13;
                    item.Height = Size.Height / 14;
                    item.Width = item.Height;
                }
                if (item is Label)
                {
                    item.Left = Size.Width / 13;
                    item.Font = new Font("Arial", Size.Width / 80, FontStyle.Bold);
                }
                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }
            }
        }

    }
}
