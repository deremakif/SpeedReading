using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Reading
{
    public partial class FormTransition : Form
    {

        //public static async Task<bool> FormCh()
        //{
        //    bool result = false;

        //    //result = await Task.Run(() => FormChange());
        //    result = true;

        //    return result;

        //}


        public void FormChange(string x1, string x2)
        {
            if (x1 =="Form1.cs" && x2 =="Form9.cs")
            {
                


                //Form9.ActiveForm.Location = new Point(t1.Location.X, t1.Location.Y);
                //t2.Size = t1.Size;
                //t2.Show();
                //t1.Hide();

                //await Task.Run(Form1.ActiveForm.Hide());
                //Application.DoEvents();
            }

        }
    }
}
