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

namespace Speed_Reading
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Form7 form7sec = new Form7();
            form7sec.Location = new Point(this.Location.X, this.Location.Y);
            form7sec.Size = this.Size;
            form7sec.Show();
            this.Hide();
        }
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Location = new Point(this.Location.X, this.Location.Y);
            form6sec.Size = this.Size;
            form6sec.Show();
            this.Hide();
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Location = new Point(this.Location.X, this.Location.Y);
            form3sec.Size = this.Size;
            form3sec.Show();
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
            //Timer timer = new Timer();
            //timer.Interval = delay;
            //timer.Tick += (s, e) =>
            //{
            //    action();
            //    timer.Stop();
            //};
            //timer.Start();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Enabled)
                {
                    _rb.Enabled = false;
                }
            }

            foreach (Control item in Controls)
            {
               
                int i = 1;

                if (radioButton1.Checked == true)
                {
                    i = 1000;
                }
                else if (radioButton2.Checked == true)
                {
                    i = 900;
                }
                else if (radioButton3.Checked == true)
                {
                    i = 800;
                }
                else if (radioButton4.Checked == true)
                {
                    i = 700;
                }
                else if (radioButton5.Checked == true)
                {
                    i = 600;
                }
                else if (radioButton6.Checked == true)
                {
                    i = 500;
                }

                Btn_Play.Enabled = false;

                if (item is PictureBox)
                {
                    item.Visible = true;
                    Application.DoEvents();
                    Thread.Sleep(i);

                    item.Visible = false;
                    Application.DoEvents();
                  
                }

                
                Btn_Play.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                radioButton6.Enabled = true;
            }





            //int i = 1;
            //int t = 0;
            //while (i < 6)
            //{
            //    Delayed(1000 + t, () => pictureBox1.Visible = true);
            //    Delayed(1500 + t, () => pictureBox1.Visible = false);
            //    Delayed(1500 + t, () => pictureBox2.Visible = true);
            //    Delayed(2000 + t, () => pictureBox2.Visible = false);
            //    Delayed(2000 + t, () => pictureBox3.Visible = true);
            //    Delayed(2500 + t, () => pictureBox3.Visible = false);
            //    Delayed(2500 + t, () => pictureBox4.Visible = true);
            //    Delayed(3000 + t, () => pictureBox4.Visible = false);
            //    Delayed(3000 + t, () => pictureBox5.Visible = true);
            //    Delayed(3500 + t, () => pictureBox5.Visible = false);
            //    Delayed(3500 + t, () => pictureBox6.Visible = true);
            //    Delayed(4000 + t, () => pictureBox6.Visible = false);
            //    Delayed(4000 + t, () => pictureBox7.Visible = true);
            //    Delayed(4500 + t, () => pictureBox7.Visible = false);
            //    Delayed(4500 + t, () => pictureBox8.Visible = true);
            //    Delayed(5000 + t, () => pictureBox8.Visible = false);
            //    Delayed(5000 + t, () => pictureBox9.Visible = true);
            //    Delayed(5500 + t, () => pictureBox9.Visible = false);
            //    Delayed(5500 + t, () => pictureBox10.Visible = true);
            //    Delayed(6000 + t, () => pictureBox10.Visible = false);

            //    t = t + 5000;
            //    i++;
            //}
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {

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
                if (item is PictureBox)
                {
                    item.Top = 1 * Size.Height / 13;
                    item.Height = 8 * Size.Height / 13;
                    item.Width = item.Height;
                    item.Left = Size.Width / 2 - item.Width / 2;
                }

                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }


            }
        }

        private void Form6_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {

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
                if (item is PictureBox)
                {
                    item.Top = 1 * Size.Height / 13;
                    item.Left = Size.Width / 2 - item.Width / 2;
                    item.Height = 8 * Size.Height / 13;
                    item.Width = item.Height;
                }

                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }
            }
        }
    }
}
