using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETLearnings
{
    public partial class RadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                Response.Write(RadioButton4.Text + " changed");
            }else if (RadioButton5.Checked)
            {
                Response.Write(RadioButton5.Text + " changed");
            }
            else if (RadioButton6.Checked)
            {
                Response.Write(RadioButton6.Text + " changed");
            }

        }
        
        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}