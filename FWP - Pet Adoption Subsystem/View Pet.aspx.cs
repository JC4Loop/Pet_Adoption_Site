using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class View_Pet : System.Web.UI.Page
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

        private static List<Pet> allPetsStatic;
        public List<Pet> sortedPetList;
        private static List<LinkButton> linkButtons;

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                allPetsStatic = DBconnection.LoadAllPets();
                Session["allPets"] = allPetsStatic;
            }
            sortedPetList = GetSortedList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CreateDynamicButtons();

            if (Session["PetSort"] != null)
            {
                sortedPetList = (List<Pet>)Session["PetSort"];
                DisplayTable(sortedPetList);
            }
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
        }

        private static void CreateDynamicButtons()
        {
            linkButtons = new List<LinkButton>();
            foreach (Pet pet in allPetsStatic)
            {
                LinkButton link = new LinkButton();                 // create Hypertext Link
                link.Text = pet.Name;
                link.ID = pet.PetID;
                link.Click += new EventHandler(LinkBtn_Click);
                linkButtons.Add(link);
                if (pet.Adopted == true)
                {
                    link.Enabled = false;
                }
            }
        }

        protected void DisplayTable(List<Pet> allPets)
        {
            int counter = 0;
            TableRow row0 = new TableRow();
            TableCell cell01 = new TableCell();
            cell01.Text = "Name";
            TableCell cell02 = new TableCell();
            cell02.Text = "Gender";
            TableCell cell03 = new TableCell();
            cell03.Text = "Age at Rescue";
            TableCell cell04 = new TableCell();
            cell04.Text = "Rescue Date";
            TableCell cell05 = new TableCell();
            cell05.Text = "Specie";
            TableCell cell06 = new TableCell();
            cell06.Text = "Breed";
            TableCell cell07 = new TableCell();
            cell07.Text = "Sanctuary";
            row0.Cells.Add(cell01);
            row0.Cells.Add(cell02);
            row0.Cells.Add(cell03);
            row0.Cells.Add(cell04);
            row0.Cells.Add(cell05);
            row0.Cells.Add(cell06);
            row0.Cells.Add(cell07);
            row0.Font.Bold = true;
            row0.Font.Underline = true;
            Table1.Rows.Add(row0);

            foreach (var pet in allPets)
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
 
                foreach (LinkButton lB in linkButtons)
                {
                    if (lB.Text == pet.Name)
                    {
                        cell1.Controls.Add(lB); // place HyperText link in cell1
                    }
                }
                      
                TableCell cell2 = new TableCell();
                cell2.Text = pet.Gender;
                TableCell cell3 = new TableCell();
                cell3.Text = pet.AgeAtRescue.ToString();
                TableCell cell4 = new TableCell();
                cell4.Text = pet.RescueDate.ToShortDateString().ToString();
                TableCell cell5 = new TableCell();
                cell5.Text = pet.Specie;
                TableCell cell6 = new TableCell();
                cell6.Text = pet.Breed;
                TableCell cell7 = new TableCell();
                cell7.Text = pet.Sanctuary;

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                row.Cells.Add(cell6);
                row.Cells.Add(cell7);
                row.Font.Size = 12;
                if (pet.Adopted == true)
                {
                    row.ForeColor = System.Drawing.Color.White;
                    row.BackColor = System.Drawing.Color.Black;
                    counter++; // helps to make row colours more consistent
                }
                else
                {
                    row.ForeColor = System.Drawing.Color.Black;
                    if (counter % 2 == 0)
                    {
                        row.BackColor = System.Drawing.Color.LightSkyBlue;
                    }
                    else
                    {
                        row.BackColor = System.Drawing.Color.LightYellow;
                    }
                }
                counter++;
                Table1.Rows.Add(row);
                Table1.BorderWidth = 1;
            }
        }

        // event for dynamic button(s)
        protected static void LinkBtn_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["PetSort"] = null;
            string petID = ((LinkButton)sender).ID;

            Pet p = allPetsStatic.Find(x => x.PetID == petID);
            HttpContext.Current.Session["SelectedPet"] = p; // save pet instance in session
            HttpContext.Current.Response.Redirect("Adopt Pet.aspx");
        }

        protected List<Pet> GetSortedList()
        {
            List<Pet> sortedList = new List<Pet>();
            string sortValue = DropDownList1.SelectedValue;
            switch (sortValue)
            {
                case "Name":
                    sortedList = allPetsStatic.OrderBy(o => o.Name).ToList();
                    break;
                case "RescueAge":
                    sortedList = allPetsStatic.OrderBy(o => o.AgeAtRescue).ToList();
                    break;
                case "Specie":
                    sortedList = allPetsStatic.OrderBy(o => o.Specie).ToList();
                    break;
                case "Breed":
                    sortedList = allPetsStatic.OrderBy(o => o.Breed).ToList();
                    break;
                case "RescueDate":
                    sortedList = allPetsStatic.OrderBy(o => o.RescueDate).ToList();
                    break;
                case "Sanctuary":
                    sortedList = allPetsStatic.OrderBy(o => o.Sanctuary).ToList();
                    break;
                default:
                    sortedList = null;
                    break;
            }
            Session["PetSort"] = sortedList;
            return sortedPetList;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}