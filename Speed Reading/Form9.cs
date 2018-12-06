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
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form9 form9sec = new Form9();
            form9sec.Location = new Point(this.Location.X, this.Location.Y);
            form9sec.Size = this.Size;
            form9sec.Show();
            this.Hide();
        }


        public void play()
        {
            pictureBox1.Location = new Point(136 * pictureBox5.Width / 1000 + pictureBox5.Left, 172 * pictureBox5.Height / 1000 + pictureBox5.Top);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(600 * pictureBox5.Width / 1000 + pictureBox5.Left, 172 * pictureBox5.Height / 1000 + pictureBox5.Top);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point( 136* pictureBox5.Width / 1000 + pictureBox5.Left,  242* pictureBox5.Height / 1000 + pictureBox5.Top);        
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(600 * pictureBox5.Width / 1000 + pictureBox5.Left,  242* pictureBox5.Height / 1000 + pictureBox5.Top);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(136 * pictureBox5.Width / 1000 + pictureBox5.Left, 324 * pictureBox5.Height / 1000 + pictureBox5.Top);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();
            pictureBox1.Location = new Point(600 * pictureBox5.Width / 1000 + pictureBox5.Left, 324 * pictureBox5.Height / 1000 + pictureBox5.Top);
            Application.DoEvents();
            Thread.Sleep(800);
            Application.DoEvents();


        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            play();

        }

        

        private void Form9_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                pictureBox5.Left = 3 * Size.Width / 100;
                pictureBox5.Top = 9 * Size.Width / 100;
                pictureBox5.Width = 92 * Size.Width / 100;
                pictureBox5.Height = 50 * Size.Height / 100;

                pictureBox1.Left = 136 * pictureBox5.Width / 1000 + pictureBox5.Left;
                pictureBox1.Top = 172 * pictureBox5.Height / 1000 + pictureBox5.Top;
                pictureBox1.Width = 172 * pictureBox5.Width / 1000;
                pictureBox1.Height = 141 * pictureBox5.Height / 10000;

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
                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }
            }

        }

        private void Form9_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                pictureBox5.Left = 3*Size.Width/100;
                pictureBox5.Top = 9 * Size.Width / 100;
                pictureBox5.Width = 92 * Size.Width / 100;
                pictureBox5.Height = 50 * Size.Height / 100;

                pictureBox1.Left = 136 * pictureBox5.Width / 1000 + pictureBox5.Left;
                pictureBox1.Top = 172 * pictureBox5.Height / 1000 + pictureBox5.Top;
                pictureBox1.Width = 172 * pictureBox5.Width / 1000;
                pictureBox1.Height = 141 * pictureBox5.Height / 10000;

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
                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }
            }
        }
    }
}
