using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class Confirm_Page : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["StaffLogin"] != null)
            {
                bool staffLogin = (bool)Session["StaffLogin"];
                if (staffLogin == true)
                {
                    this.Page.MasterPageFile = "~/StaffMast.master";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Using this page must have a list, with 1 bool, 1 string
            if (Session["ConfirmBoolString"] != null)
            {
                List<object> results = new List<object>();
                results = (List<object>)Session["ConfirmBoolString"];
                bool b = (bool)results[0];
                string s1 = (string)results[1]; // Message
  
                LblConfirm.Text = s1;
            }
            else
            {
                LblConfirm.Text = "Error this should't happen";
            }
        }
    }
}