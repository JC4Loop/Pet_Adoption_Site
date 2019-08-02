using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class StaffMast : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Staff Logged in as " + Session["StaffLinName"];
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = null;
            Session["StaffLogin"] = false;
            Response.Redirect("Staff_Log_In.aspx");
        }
    }
}