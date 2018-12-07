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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            
            
        }
        

        private void Form14_Load(object sender, EventArgs e)
        {
            

            foreach (Control item in Controls)
            {
                pictureBox1.Width = 616 * Size.Width / 1000;
                pictureBox1.Height = 805 * Size.Height / 1000;
                pictureBox1.Left = 191 * Size.Width / 1000;
                pictureBox1.Top = 40 * Size.Height / 1000;


                form15sec.Location = new Point(this.Location.X + 191 * Size.Width / 1000, this.Location.Y + 40 * Size.Height / 100);
                form15sec.Width = pictureBox1.Width;
                form15sec.Height = pictureBox1.Height / 5;

                //form16sec.Location = new Point(pictureBox1.Left + this.Location.X, pictureBox1.Top + 3 * pictureBox1.Height / 5 + this.Location.Y);
                //form16sec.Width = pictureBox1.Width;
                //form16sec.Height = pictureBox1.Height / 5;

              

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
        Form15 form15sec = new Form15();
        //Form16 form16sec = new Form16();

        private void Form14_SizeChanged(object sender, EventArgs e)
        {
           

            foreach (Control item in Controls)
            {
                pictureBox1.Width = 616 * Size.Width / 1000;
                pictureBox1.Height = 805 * Size.Height / 1000;
                pictureBox1.Left = 191 * Size.Width / 1000;
                pictureBox1.Top = 40 * Size.Height / 1000;

                form15sec.Location = new Point(this.Location.X + 191 * Size.Width / 1000, this.Location.Y + 40 * Size.Height / 100);
                form15sec.Width = pictureBox1.Width;
                form15sec.Height = pictureBox1.Height / 5;

                //form16sec.Location = new Point(pictureBox1.Left + this.Location.X, pictureBox1.Top+3*pictureBox1.Height/5 + this.Location.Y);
                //form16sec.Width = pictureBox1.Width;
                //form16sec.Height = pictureBox1.Height / 5;

               

                Btn_Pause.Left = Size.Width / 2;
                Btn_Play.Left = Btn_Pause.Left - Btn_Play.Width;
                Btn_Back.Left = Btn_Play.Left - Btn_Back.Width;
                Btn_Next.Left = Btn_Pause.Left + Btn_Pause.Width;

                menuStrip1.Width = Size.Width;
                menuStrip1.Height = 34*Size.Height /1000;

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

        private void menuStrip1_Resize(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            
            form15sec.Show();
            form15sec.Focus();
            //form16sec.Show();

        }
    }
}