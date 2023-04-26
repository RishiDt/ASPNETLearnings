using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ASPNETLearnings
{
    public partial class PlayGroundForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //part 17
            DataSet DS = new DataSet();
            DS.ReadXml(Server.MapPath("Files/XMLFile1.xml"));
            DropDownList1.DataTextField = "elementName"; //should be called before 
            DropDownList1.DataValueField = "elementValue";  //should be called before 
            DropDownList1.DataSource = DS;
            DropDownList1.DataBind();
            
            ListItem li = new ListItem("select", "-1");
            DropDownList1.Items.Insert(0, li);

        }

        //part 17
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}