using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETLearnings.WebForms
{
    public partial class PlayGroundForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            //part 21
            if (!IsPostBack)
            {
                DropDownList1.SelectedValue = "Ar";
            }


            //part23
        }

        //part 19
        protected void Button1_Click(object sender, EventArgs e)
        {   
            Response.Write("arguements \".\" " + Server.MapPath(".") + "<br>");
            Response.Write("arguements \"..\" " + Server.MapPath("..") + "<br>");
            Response.Write("arguements \"~\" " + Server.MapPath("~") + "<br>");

        }

        //part21
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Selected Text: "+DropDownList1.SelectedItem.Text + "<br>");
            Response.Write("Selected Value: " + DropDownList1.SelectedItem.Value + "<br>");
            Response.Write("Selected Index: " + DropDownList1.SelectedIndex + "<br>");

        }

        //part 23
        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach(ListItem li in CheckBoxList1.Items)
            {

                if (li.Selected)
                {
                    Response.Write("for Index  " + CheckBoxList1.Items.IndexOf(li) + ", ");
                    Response.Write("Text  " + li.Text + ", ");
                    Response.Write("value " + li.Value + ", ");
                    Response.Write("<br>"); 
                }
            }
        }


        //part24
        protected void Button4_Click(object sender, EventArgs e)
        {

            foreach(ListItem li in CheckBoxList2.Items)
            {
                if (li.Selected)
                {
                    Response.Write("selected : " + li.Text+", ");
                }
            }
        }

        //part 24
        protected void Button5_Click(object sender, EventArgs e)
        { //overwrites selection 
            CheckBoxList2.SelectedIndex = 1;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            foreach(ListItem li in CheckBoxList2.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in CheckBoxList2.Items)
            {
                li.Selected = false;
            }
        }
    }
}