using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class Terminate_Adoption : System.Web.UI.Page
    {
        private List<Adoption> activeAdoptions;
        static Adoption adoption;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ActiveAdoptions"] == null)
            {
                Response.Redirect("View_Adoptions.aspx");
            }
            activeAdoptions = (List<Adoption>)Session["ActiveAdoptions"];
            DisplayActiveAdoptionTable();
        }

        private void DisplayActiveAdoptionTable()
        {
            TableRow row0 = new TableRow();
            TableCell cell00 = new TableCell();
            cell00.Text = "Adoption ID";
            TableCell cell01 = new TableCell();
            cell01.Text = "Customer";
            TableCell cell02 = new TableCell();
            cell02.Text = "Pet Name";
            TableCell cell03 = new TableCell();
            cell03.Text = "Pet Specie";
            TableCell cell04 = new TableCell();
            cell03.Text = "Deposit Amount";

            row0.Cells.Add(cell00);
            row0.Cells.Add(cell01);
            row0.Cells.Add(cell02);
            row0.Cells.Add(cell03);
            row0.Cells.Add(cell04);
            row0.Font.Bold = true;
            row0.Font.Underline = true;
            TableActiveAdoptions.Rows.Add(row0);

            int counter = 0;
            foreach (Adoption a in activeAdoptions)
            {
                TableRow row = new TableRow();
                TableCell cell0 = new TableCell();

                LinkButton link = new LinkButton();                 // create Hypertext Link
                link.Text = a.AdoptionID;
                link.ID = a.AdoptionID;
                link.Click += new EventHandler(LinkBtn_Click);

                cell0.Controls.Add(link);
                TableCell cell1 = new TableCell();
                cell1.Text = a.Customer.CName;
                TableCell cell2 = new TableCell();
                cell2.Text = a.Pet.Name;
                TableCell cell3 = new TableCell();
                cell3.Text = a.Pet.Specie;
                TableCell cell4 = new TableCell();
                cell3.Text = String.Format("£{0:0.00}", a.Deposit);
                row.Cells.Add(cell0);
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
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

                TableActiveAdoptions.Rows.Add(row);
                TableActiveAdoptions.BorderWidth = 1;
            }
        }
        protected void LinkBtn_Click(object sender, EventArgs e)
        {
            string adoptID = ((LinkButton)sender).ID;
            Adoption a = activeAdoptions.Find(x => x.AdoptionID == adoptID);
            adoption = a;
            LabelsAndButtonsGUI();    
        }

        protected void BtnCnfmTerm_Click(object sender, EventArgs e)
        {     
            List<object> results = Adoption.TerminateAdoption(adoption);

            Session["ConfirmBoolString"] = results;
            Response.Redirect("Confirm_Page.aspx");
        }

        private void LabelsAndButtonsGUI()
        {
            LblWhichAdoption.Text = "Terminate Adoption " + adoption.AdoptionID;
            BtnCnfmTerm.Visible = true;
            LblAdDate.Text = "" + adoption.AdDate.ToShortDateString();
            LblCustomer.Text = adoption.Customer.CName;
            LblDeposit.Text = String.Format("£{0:0.00}", adoption.Deposit);
            LblPet.Text = adoption.Pet.Name;
            LblPetSpecie.Text = adoption.Pet.Specie;
            LblPSanc.Text = adoption.Pet.Sanctuary;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("View_Adoptions.aspx");
        }
    }
}