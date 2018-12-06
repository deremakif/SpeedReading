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
                

                if (item is SimpleButton)
                {
                    
                    item.Top = Size.Height - 100;
                }
                

                
            }
        }

        private void Form13_Resize(object sender, EventArgs e)
        {
            SetComponents();
            
        }
    }
}
