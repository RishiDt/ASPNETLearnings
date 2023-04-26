using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ASPNETLearnings
{
    public partial class CheckBox : System.Web.UI.Page
    {
        StringBuilder sb1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBox1.Checked = true; //checking by the page load 
           
         

        }

        protected void populatesb1()
        {
            StringBuilder sb = new StringBuilder();
            if (CheckBox1.Checked)
            {
                sb.Append(CheckBox1.Text + ",  ");
            }
            if (CheckBox2.Checked)
            {
                sb.Append(CheckBox2.Text + ",  ");
            }
            if (CheckBox3.Checked)
            {
                sb.Append(CheckBox3.Text + ",  ");
            }

            sb1 = sb;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("cb1 change detected <br>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            populatesb1();
            Response.Write("these are checked : "+sb1);
        }
    }
}