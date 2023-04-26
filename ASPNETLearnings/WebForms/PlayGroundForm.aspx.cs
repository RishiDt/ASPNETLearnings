using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETLearnings
{
    public partial class HyperLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //part 15
            Button1.Click += new EventHandler(Button1_Click);
            Button1.Command += new CommandEventHandler(Button1_Command);

            //part 16
            if (!IsPostBack)
            {
                ListItem l1 = new ListItem("name1", "value1");
                ListItem l2 = new ListItem("name2", "value2");

                DropDownList1.Items.Add(l1);
                DropDownList1.Items.Add(l2);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("button clicked");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            
            Response.Write("button command event");
        }

        protected void ButtonCommandHandler(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "c1")
                Response.Write("command c1 ");
            if (e.CommandName.ToString() == "c2" && e.CommandArgument.ToString()=="arg1")
                Response.Write("command c2 and arg1");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}