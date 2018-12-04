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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
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
                    item.Top = Size.Height - 100;
                }


                //button1.Left = 10;
                //button1.Top = 10;

                //button2.Left = button1.Right + 10;
                //button2.Top = button1.Top;
            }
        }

        private void Form13_Resize(object sender, EventArgs e)
        {
            SetComponents();
        }
    }
}
