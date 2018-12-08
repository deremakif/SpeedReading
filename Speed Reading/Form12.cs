using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Speed_Reading
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        /*
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=Users;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
           string query = "Select * from users Where userName = '"+textBox1.Text.Trim() +"' and userPassword = '"+textBox2.Text.Trim()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            sqlcon.Close();
            if (dtbl.Rows.Count==1)
            {
                Form1 form1sec = new Form1();
                form1sec.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        */

        private void button1_Click(object sender, EventArgs e)
        {            
            if (textBox1.Text=="akif" && textBox2.Text=="abc")
            {
                Form1 form1sec = new Form1();
                form1sec.Size = this.Size;
                form1sec.Location = new Point(this.Location.X, this.Location.Y);
                
                form1sec.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }
}
