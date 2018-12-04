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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Form5 form5sec = new Form5();
            form5sec.Show();
            this.Hide();
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form10 form10sec = new Form10();
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
            int i = 1;
            int t = 0;
            while (i < 6)
            {
                Delayed(1000 + t, () => pBox1.Visible = true);
                Delayed(1500 + t, () => pBox1.Visible = false);
                Delayed(1500 + t, () => pBox2.Visible = true);
                Delayed(2000 + t, () => pBox2.Visible = false);
                Delayed(2000 + t, () => pBox3.Visible = true);
                Delayed(2500 + t, () => pBox3.Visible = false);
                Delayed(2500 + t, () => pBox4.Visible = true);
                Delayed(3000 + t, () => pBox4.Visible = false);

                t = t + 2000;
                i++;
            }
        }
    }
}
