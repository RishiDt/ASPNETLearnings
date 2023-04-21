using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class LifecycleWebForm : System.Web.UI.Page
    {
     
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit" + "<br/>");
            if (IsPostBack) Response.Write("postback preinit<br>");

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init" + "<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete" + "<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load" + "<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender" + "<br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("" + "<br/>");
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            Response.Write("" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
             //Response.Write("" + "<br/>"); gives error
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("button clicked<br>");
            //Button1.Visible = false;
        }
    }



}
