using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class Hall_of_Fame : System.Web.UI.Page
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
            List<Adoption> adoptionsAbove = DBconnection.LoadAllAdoptions();
            List<Adoption> adoptionDescD = SortDeposits(adoptionsAbove);
            DisplayFameTable(adoptionDescD);
        }

        private List<Adoption> SortDeposits(List<Adoption> allAds)
        {
            List<Adoption> sortDescAdoptions = new List<Adoption>();

            foreach(Adoption a in allAds)
            {
                Pet p = a.Pet;
                double minumumDeposit = Pet.CheckMinPetDeposit(p);
                if (a.Deposit > minumumDeposit)
                {
                    sortDescAdoptions.Add(a);
                }
            }
            sortDescAdoptions = sortDescAdoptions.OrderByDescending(o => o.Deposit).ToList();
            return sortDescAdoptions;
        }

        protected void DisplayFameTable(List<Adoption> genAdoptions)
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
            TableCell cell05 = new TableCell();
            cell05.Text = "More than minimum";
            row0.Cells.Add(cell01);
            row0.Cells.Add(cell02);
            row0.Cells.Add(cell03);
            row0.Cells.Add(cell04);
            row0.Cells.Add(cell05);
            row0.Font.Bold = true;
            row0.Font.Underline = true;
            Table1.Rows.Add(row0);
            Adoption a;
            for (int counter = 0; counter < genAdoptions.Count; counter++)
            {
                a = genAdoptions[counter];

                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = a.Customer.CName;
                TableCell cell2 = new TableCell();
                cell2.Text = a.Pet.Name;
                TableCell cell3 = new TableCell();
                cell3.Text = a.Pet.Specie;
                TableCell cell4 = new TableCell();
                cell4.Text = String.Format("£{0:0.00}", a.Deposit);
                TableCell cell5 = new TableCell();
                
                Pet p = a.Pet;
                double nDifference = a.Deposit - Pet.CheckMinPetDeposit(p);
                cell5.Text = String.Format("£{0:0.00}", nDifference);
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
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

                Table1.Rows.Add(row);
                Table1.BorderWidth = 1;
        }
       }
    }
}
