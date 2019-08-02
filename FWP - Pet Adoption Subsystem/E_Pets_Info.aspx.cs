using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class E_Pets_Info : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {   //if session is set (staff logged in)
            if (Session["StaffLogin"] != null)
            {
                bool staffLogin = (bool)Session["StaffLogin"];
                if (staffLogin == true)
                {   // if staff is logged in change master page
                    this.Page.MasterPageFile = "~/StaffMast.master";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<EndangeredPet> allEndangPets = DBconnection.LoadEndangeredPets();
            // new list without duplicate pet species
            List<EndangeredPet> oneOfEachEP = ChangeList(allEndangPets);

            // order by - endanger cantegory (critically, extinct in, etc)
            oneOfEachEP = oneOfEachEP.OrderBy(o => o.EndangCategString()).ToList();
            DisplayPetTable(oneOfEachEP);

            List<Pet> noEPets = DBconnection.LoadNonEndangPets();
            List<Pet> noEPets2 = ChangeList(noEPets);

            // order non endangered pets by - species
            noEPets2 = noEPets2.OrderBy(o => o.Specie).ToList();
            RenderListBox(noEPets2);
            RenderListBox(oneOfEachEP);
        }

        protected void DisplayPetTable(List<EndangeredPet> ePets)
        {
            TableRow row0 = new TableRow();
            TableCell cell01 = new TableCell();
            cell01.Text = "Specie";
            TableCell cell02 = new TableCell();
            cell02.Text = "Breed";
            TableCell cell03 = new TableCell();
            cell03.Text = "Endangered Category";
            TableCell cell04 = new TableCell();

            row0.Cells.Add(cell01);
            row0.Cells.Add(cell02);
            row0.Cells.Add(cell03);
            row0.Cells.Add(cell04);
            row0.Font.Bold = true;
            row0.ForeColor = System.Drawing.Color.Black;
            row0.Font.Underline = true;
            Table1.Rows.Add(row0);
            int counter = 0;
            foreach (EndangeredPet ep in ePets)
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = ep.Specie;
                TableCell cell2 = new TableCell();
                cell2.Text = ep.Breed;
                TableCell cell3 = new TableCell();
                cell3.Text = ep.EndangCategString();
                TableCell cell4 = new TableCell();
                Image image = new Image();
                image.ImageUrl = "Images/image" + ep.GetImageString() + ".jpg";
                cell4.Controls.Add(image);
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
                Table1.Rows.Add(row);
                Table1.BorderWidth = 1;
                counter++;
            }
        }

        private List<EndangeredPet> ChangeList(List<EndangeredPet> list)
        {
            List<EndangeredPet> noDuplicateList = new List<EndangeredPet>();
            string currentBreed;
            int i = 0;
            foreach(EndangeredPet e in list)
            {
                bool bDuplicate = false;
                if (i == 0) // will only be true on first cycle
                {
                    noDuplicateList.Add(e);
                    i++;
                }
                else // after first item placed in list
                {
                    currentBreed = e.Breed;
                    foreach (EndangeredPet ep in noDuplicateList) // for every item in new list
                    {
                        if (ep.Breed == currentBreed)  // if breed of item in new list is equal to item in old list
                        {
                            bDuplicate = true;  // duplicate found
                            break;   // step out of current inner loop
                        }
                    }
                    if (bDuplicate == false) // if no duplicate found
                    {
                        noDuplicateList.Add(e); // add item to new list
                        bDuplicate = false;   // set bool back to false
                    }
                }
            }
            return noDuplicateList;
        }

        private List<Pet> ChangeList(List<Pet> list)
        {
            List<Pet> noDuplicateList = new List<Pet>();
            string currentBreed;
            int i = 0;
            foreach (Pet e in list)
            {
                bool bDuplicate = false;
                if (i == 0)
                {
                    noDuplicateList.Add(e);
                    i++;
                }
                else // after first item placed in list
                {
                    currentBreed = e.Breed;
                    foreach (Pet ep in noDuplicateList) // for every item in new list
                    {
                        if (ep.Breed == currentBreed)  // if breed of item in new list is equal to item in old list
                        {
                            bDuplicate = true;  // duplicate found
                            break;   // step out of loop
                        }
                    }
                    if (bDuplicate == false) // if no duplicate found
                    {
                        noDuplicateList.Add(e); // add item to new list
                        bDuplicate = false;   // set bool back to false
                    }
                }   // if duplicate is found don't add pet to list and continue loop
            }
            return noDuplicateList;
        }

        private void RenderListBox(List<Pet> list)
        {
            int specieLength = 0;
            int breedLength = 0;
            foreach (Pet p in list)
            {
                if (p.Specie.Length > specieLength)
                {
                    specieLength = p.Specie.Length;
                }
                if (p.Breed.Length > breedLength)
                {
                    breedLength = p.Breed.Length;
                }
            }
            foreach (Pet p in list)
            {
                ListBox1.Items.Add("Specie: " + p.Specie.PadRight(specieLength + 1) + " Breed: " + p.Breed.PadRight(breedLength + 1) + " " + p.GetDetailLines());
            }
        }

        private void RenderListBox(List<EndangeredPet> list)
        {
            int specieLength = 0;
            int breedLength = 0;
            foreach (EndangeredPet p in list)
            {
                if (p.Specie.Length > specieLength)
                {
                    specieLength = p.Specie.Length;
                }
                if (p.Breed.Length > breedLength)
                {
                    breedLength = p.Breed.Length;
                }
            }
            
            foreach (EndangeredPet p in list)
            {
                ListBox1.Items.Add("Specie: " + p.Specie.PadRight(specieLength + 1) + " Breed: " + p.Breed.PadRight(breedLength + 1) + " " + p.GetDetailLines());
            }
        }
    }
}