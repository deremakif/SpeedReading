using DevExpress.XtraEditors;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Form11 form11sec = new Form11();
            form11sec.Location = new Point(this.Location.X, this.Location.Y);
            form11sec.Size = this.Size;
            form11sec.Show();
            this.Hide();
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Location = new Point(this.Location.X, this.Location.Y);
            form1sec.Size = this.Size;
            form1sec.Show();
            this.Hide();
        }
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form10 form10sec = new Form10();
            form10sec.Location = new Point(this.Location.X, this.Location.Y);
            form10sec.Size = this.Size;
            form10sec.Show();
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
            Delayed(10, () => label1.Visible = true);
            Delayed(2000, () => label2.Visible = true);
            Delayed(2000, () => label3.Visible = true);
            Delayed(2000, () => label4.Visible = true);
            Delayed(10000, () => label5.Visible = true);
            Delayed(10000, () => label6.Visible = true);
            Delayed(10000, () => label7.Visible = true);
            Delayed(10000, () => label8.Visible = true);
            Delayed(10000, () => label9.Visible = true);

        }

        private void Form10_SizeChanged(object sender, EventArgs e)
        {
            Btn_Pause.Left = Size.Width / 2;
            Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
            Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
            Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

            foreach (Control item in Controls)
            {

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
                

            }

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Btn_Pause.Left = Size.Width / 2;
            Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
            Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
            Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

            foreach (Control item in Controls)
            {

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

            }

        }

       
    }
}
