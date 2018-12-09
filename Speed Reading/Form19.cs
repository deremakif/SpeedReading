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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                radioButton1.Checked = true;

                label1.Top = 3 * Size.Height / 13;
                label2.Top = 6 * Size.Height / 13;

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
                    item.Left = Size.Width / 3;
                    item.Font = new Font("Arial", Size.Width / 80, FontStyle.Bold);

                    item.Width = Size.Width / 3;
                    item.Height = 2 * Size.Height / 13;

                }
                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }
            }
        }

        private void Form19_Resize(object sender, EventArgs e)
        {

        }

        private void Form19_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {

                label1.Top = 3 * Size.Height / 13;
                label2.Top = 6 * Size.Height / 13;

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
                    item.Left = Size.Width / 3;
                    item.Font = new Font("Arial", Size.Width / 80, FontStyle.Bold);

                    item.Width = Size.Width / 3;
                    item.Height = 2 * Size.Height / 13;
                }
                foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
                {
                    tsmi.Width = Size.Width / 22;
                }
            }
        }

        List<string> lbl1 = new List<string>(new string[]
            {
                "Lorem ipsum", "dolor sit amet","consectetur adipiscing elit","sed do eiusmod tempor","incididunt ut labore","et dolore magna aliqua","Ut enim ad minim","veniam, quis nostrud","exercitation ullamco laboris","nisi ut aliquip ex","ea commodo consequat."
            });

        List<string> lbl2 = new List<string>(new string[]
            {

        "Duis aute irure dolor in","reprehenderit in voluptate velit","esse cillum dolore eu","fugiat nulla pariatur","Excepteur sint occaecat","cupidatat non proident","sunt in culpa qui","officia deserunt mollit","anim id est laborum."
                        });



        private void Btn_Play_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            Btn_Play.Enabled = false;

            int i =1;

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



            var lbl1And2 = lbl1.Zip(lbl2, (n, w) => new { Number = n, Word = w });

            foreach (var nw in lbl1And2)
            {
                label1.Text = nw.Number;
                Application.DoEvents();
                Thread.Sleep(i);

                label2.Text = nw.Word;
                Application.DoEvents();
                Thread.Sleep(i);

            }

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            Btn_Play.Enabled = true;

        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Form19 form19sec = new Form19();
            form19sec.Location = new Point(this.Location.X, this.Location.Y);
            form19sec.Size = this.Size;
            form19sec.Show();
            this.Hide();
        }
    }
}
