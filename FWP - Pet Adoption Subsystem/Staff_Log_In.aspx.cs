using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Username : ab123
// password : abc
namespace FWP___Pet_Adoption_Subsystem
{
    public partial class Staff_Log_In : System.Web.UI.Page
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = TBxUName.Text;
            string password = TBxUPasswrd.Text;
            List<object> loginAttempt = DBconnection.LogInStaff(userName, password);
            string message = "";
            bool staffLogin;
            try
            {
                bool dbSuccess = (bool)loginAttempt[0];
                if (dbSuccess == true)
                {
                    bool loginSuccess = (bool)loginAttempt[1];
                    if (loginSuccess == true)
                    {
                        string liUserName = (string)loginAttempt[2];
                        string liPassword = (string)loginAttempt[3];
                        Session["StaffLinName"] = liUserName;
                        staffLogin = true;
                        Session["StaffLogin"] = staffLogin;
                        Response.Redirect("View_Adoptions.aspx");
                    }
                    else
                    {
                        message = "Username or password is incorrect";
                    }
                }
                else
                {
                    message = "Database connection error";
                }
            }
            catch (Exception ex)
            {
                message = "" + ex;
            }
            finally
            {
                lblMessageDisplay.Text = message;
            }
        }
    }
}