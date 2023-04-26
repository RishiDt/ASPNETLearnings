using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class sessionWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["clicks"] == null)
                    Session["clicks"] = 0;
            }
            TextBox1.Text = Session["clicks"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clicksCount= Convert.ToInt32(Session["clicks"].ToString());
            clicksCount++;
            TextBox1.Text = clicksCount.ToString();
            Session["clicks"] = clicksCount.ToString();
        }
    }
}