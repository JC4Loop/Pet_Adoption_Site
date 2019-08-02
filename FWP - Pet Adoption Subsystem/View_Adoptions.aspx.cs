using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class View_Adoptions : System.Web.UI.Page
    {
        List<Adoption> allAdoptions;
        static List<Adoption> activeAdoptions;
        static bool viewAll = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            allAdoptions = DBconnection.LoadAllAdoptions();
            if (!Page.IsPostBack)
            {
                activeAdoptions = new List<Adoption>();
                foreach (Adoption a in allAdoptions)
                {
                    if (a.Terminated == false)
                    {
                        activeAdoptions.Add(a);
                    }
                }
                LnkBtnAll.Enabled = false;
                Label2.Text = "All Adoptions";
                DisplayAdoptionTable(allAdoptions);
            }
         
            double totalDeposit = 0;
            foreach (Adoption a in allAdoptions)
            {
                totalDeposit += a.Deposit;
            }
            LblDepositTotal.Text = String.Format("Total amount from deposits is £{0:0.00}", totalDeposit);


        }

        private void DisplayAdoptionTable(List<Adoption> adoptions)
        {
            TableRow row0 = new TableRow();
            TableCell cell01 = new TableCell();
            cell01.Text = "Customer";
            TableCell cell02 = new TableCell();
            cell02.Text = "Pet Name";
            TableCell cell03 = new TableCell();
            cell03.Text = "Pet Specie";
            TableCell cell04 = new TableCell();
            cell04.Text = "Deposit Amount";

            row0.Cells.Add(cell01);
            row0.Cells.Add(cell02);
            row0.Cells.Add(cell03);
            row0.Cells.Add(cell04);
            if (viewAll == true)
            {
                TableCell cell05 = new TableCell();
                cell05.Text = "Date Adoption was terminated";
                row0.Cells.Add(cell05);
            }
            row0.Font.Bold = true;
            row0.Font.Underline = true;
            TableAllAdoptions.Rows.Add(row0);

            int counter = 0;
            foreach (Adoption a in adoptions)
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = a.Customer.CName;
                TableCell cell2 = new TableCell();
                cell2.Text = a.Pet.Name;
                TableCell cell3 = new TableCell();
                cell3.Text = a.Pet.Specie;
                TableCell cell4 = new TableCell();
                cell4.Text = String.Format("£{0:0.00}", a.Deposit);

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                if (viewAll == true)
                {
                    TableCell cell5 = new TableCell();
                    if (a.Terminated == true)
                    {
                        cell5.Text = a.TerminDate.ToShortDateString();
                    }
                    else
                    {
                        cell5.Text = "N/A";
                    }
                    row.Cells.Add(cell5);
                }
                row.Font.Size = 12;
                row.ForeColor = System.Drawing.Color.Black;
                if (counter % 2 == 0)
                {
                    row.BackColor = System.Drawing.Color.LightSkyBlue;
                }
                else
                {
                    row.BackColor = System.Drawing.Color.LightYellow;
                }
                counter++;

                TableAllAdoptions.Rows.Add(row);
                TableAllAdoptions.BorderWidth = 1;
            }
        }

        protected void LnkBtnActive_Click(object sender, EventArgs e)
        {
            viewAll = false;
            DisplayAdoptionTable(activeAdoptions);
            LnkBtnActive.Enabled = false;
            LnkBtnAll.Enabled = true;
            Label2.Text = "Active Adoptions";
        }

        protected void LnkBtnAll_Click(object sender, EventArgs e)
        {
            viewAll = true;
            DisplayAdoptionTable(allAdoptions);
            LnkBtnActive.Enabled = true;
            LnkBtnAll.Enabled = false;
            Label2.Text = "All Adoptions";
        }

        protected void BtnTerminatePage_Click(object sender, EventArgs e)
        {
            Session["ActiveAdoptions"] = activeAdoptions;
            Response.Redirect("Terminate_Adoption.aspx");
        }
    }
}