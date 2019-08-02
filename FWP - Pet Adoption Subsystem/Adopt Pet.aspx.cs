using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class Adopt_Pet : System.Web.UI.Page
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

        Pet pet;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Make sure pet has been selected, otherwise redirect
            if (!Page.IsPostBack && Session["SelectedPet"] == null)
            {
                Response.Redirect("View Pet.aspx");
            }
            AdoptPageGUI();   
        }

        private void AdoptPageGUI()
        {
            pet = (Pet) Session["SelectedPet"];

            LblPetNameA.Text = pet.Name;
            LblPetBreed.Text = pet.Breed;
            LblPetGender.Text = pet.Gender;
            LblPetRAge.Text = "" + pet.AgeAtRescue;
            LblPetRescueD.Text = "" + pet.RescueDate.ToShortDateString();
            LblPetSpecie.Text = pet.Specie;
            LblPetSanc.Text = pet.Sanctuary;
          
            LblPetNameB.Text = pet.Name;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string cCountry = DdListCountry.SelectedValue;
            if (cCountry != pet.Sanctuary)
            {
                LblcConfirm.Text = "! You can only adopt a Pet in the same country";
            }
            else
            {
                string cName = TBxAName.Text;
                string cEmail = TBxAEmail.Text;
                string cAdd1 = TBxAadd1.Text;
                string cAdd2 = TBxAadd2.Text;
                string ctelNum = TBATelenum.Text;

                //public Customer(string n, string e, string a1, string a2, string c, string t)
                Customer c = new Customer(cName, cEmail, cAdd1, cAdd2, cCountry,ctelNum);
                Session["customerDetails"] = c;
                Response.Redirect("Adoption_Deposit.aspx");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("View Pet.aspx");
        } 
    }
}