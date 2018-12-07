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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is Label)
                {
                    item.BackColor = Color.Red;
                    Application.DoEvents();
                    Thread.Sleep(600);
                    item.BackColor = Color.Black;
                    Application.DoEvents();
                    Thread.Sleep(1);
                }

            }
        }
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form17 form17sec = new Form17();
            form17sec.Size = this.Size;
            form17sec.Location = new Point(this.Location.X, this.Location.Y);
            form17sec.Show();
            this.Hide();
        }


        private void Form17_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {

                Btn_Pause.Left = Size.Width / 2;
                Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
                Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
                Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

                label1.Top = 5 * Size.Height / 31;
                label2.Top = 6 * Size.Height / 31;
                label3.Top = 7 * Size.Height / 31;
                label4.Top = 8 * Size.Height / 31;
                label5.Top = 9 * Size.Height / 31;
                label6.Top = 10 * Size.Height / 31;
                label7.Top = 11 * Size.Height / 31;
                label8.Top = 12 * Size.Height / 31;
                label9.Top = 13 * Size.Height / 31;
                label10.Top = 14 * Size.Height / 31;
                label11.Top = 15 * Size.Height / 31;
                label12.Top = 16 * Size.Height / 31;
                label13.Top = 17 * Size.Height / 31;
                label14.Top = 18 * Size.Height / 31;
                label15.Top = 19 * Size.Height / 31;
                label16.Top = 20 * Size.Height / 31;
                label17.Top = 21 * Size.Height / 31;
                label18.Top = 22 * Size.Height / 31;
                label19.Top = 23 * Size.Height / 31;
                label20.Top = 24 * Size.Height / 31;

                if (item is Label)
                {
                    item.Font = new Font("Arial", 2 * this.Height / 100);
                    item.Left = Width / 2 - item.Width / 2;
                }

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

        private void Form17_SizeChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
            {
                tsmi.Width = Size.Width / 22;
            }
            foreach (Control item in Controls)
            {
                if (item is Label)
                {
                    item.Font = new Font("Arial", 2 * Height / 100);
                    item.Left = Width / 2 - item.Width / 2;  
                }

                if (item is SimpleButton)
                {
                    item.Top = 11 * Size.Height / 13;
                    item.Height = Size.Height / 14;
                    item.Width = item.Height;
                }
            }

            Btn_Pause.Left = Size.Width / 2;
            Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
            Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
            Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

            label1.Top = 5 * Size.Height / 31;
            label2.Top = 6 * Size.Height / 31;
            label3.Top = 7 * Size.Height / 31;
            label4.Top = 8 * Size.Height / 31;
            label5.Top = 9 * Size.Height / 31;
            label6.Top = 10 * Size.Height / 31;
            label7.Top = 11 * Size.Height / 31;
            label8.Top = 12 * Size.Height / 31;
            label9.Top = 13 * Size.Height / 31;
            label10.Top = 14 * Size.Height / 31;
            label11.Top = 15 * Size.Height / 31;
            label12.Top = 16 * Size.Height / 31;
            label13.Top = 17 * Size.Height / 31;
            label14.Top = 18 * Size.Height / 31;
            label15.Top = 19 * Size.Height / 31;
            label16.Top = 20 * Size.Height / 31;
            label17.Top = 21 * Size.Height / 31;
            label18.Top = 22 * Size.Height / 31;
            label19.Top = 23 * Size.Height / 31;
            label20.Top = 24 * Size.Height / 31;



        }

       
    }
}
