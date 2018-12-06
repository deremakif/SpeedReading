using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Speed_Reading
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        //SqlConnection sc = new SqlConnection();

        string kullaniciadi = "akif";
        string sifre = "abc";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "akif" && textBox2.Text == "abc")
            {
                Form1 form1sec = new Form1();
                form1sec.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
