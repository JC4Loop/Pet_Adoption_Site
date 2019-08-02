using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWP___Pet_Adoption_Subsystem
{
    public partial class Adoption_Deposit : System.Web.UI.Page
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
        Customer customer;
        private static double amountGDP;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Make sure pet has been selected, otherwise redirect
            if (!Page.IsPostBack && Session["SelectedPet"] == null)
            {
                Response.Redirect("View Pet.aspx");
            }
            pet = (Pet)Session["SelectedPet"];
            customer = (Customer)Session["customerDetails"];

            DisplayGui();
        }

        private void DisplayGui()
        {
            LabelName.Text = pet.Name;
            LabelGender.Text = pet.Gender;
            LabelSpecie.Text = pet.Specie;
            LabelBreed.Text = pet.Breed;
            LabelRescueA.Text = pet.AgeAtRescue.ToString();
            LabelRescueD.Text = pet.RescueDate.ToString();

            LabelCName.Text = customer.CName;
            LabelCEmail.Text = customer.CEmail;
            LabelCTelNum.Text = customer.TeleNum;
            LabelCAdd1.Text = customer.CAdd1;
            LabelCAdd2.Text = customer.CAdd2;
            LabelCCoR.Text = customer.CCountry;
            LbldisplayMinD.Text = "£" + Pet.CheckMinPetDeposit(pet);
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            double minimumDeposit = Pet.CheckMinPetDeposit(pet);
            double amountEx;
            // GDP, EUR , RON
            string currencyType = DropDownList1.SelectedValue;
            if (currencyType == "GDP")
            {
                amountGDP = Convert.ToDouble(TBxDeposit.Text);

                LblDepAmount.Text = "GDP Deposit of\n";
            }
            else if (currencyType == "EUR")
            {
                amountEx = Convert.ToDouble(TBxDeposit.Text);
                amountGDP = DepositExchangeRate.ExchangeEurToGDP(amountEx);
                LblDepAmount.Text = "EUR Deposit of " + Math.Round(amountEx,2) + " is\n";
            }
            else if (currencyType == "RON")
            {
                amountEx = Convert.ToDouble(TBxDeposit.Text);
                amountGDP = DepositExchangeRate.ExchangeRONToGDP(amountEx);
                LblDepAmount.Text = "RON Deposit of " + Math.Round(amountEx, 2) + " is\n";
            }
            else
            {
                amountGDP = 0;
            }

            LblDepAmount.Text += "" + amountGDP;

            if (amountGDP < minimumDeposit)
            {
                LblDepAmount.Text = "\nDeposit is less that required for this pet specie";
                BtnConfirmOrd.Enabled = false;
                BtnConfirmOrd.Text = "Please input another deposit amount";
            }
            else
            {
                BtnConfirmOrd.BackColor = System.Drawing.Color.White;
                BtnConfirmOrd.Enabled = true;
                BtnConfirmOrd.Width = 250;
                BtnConfirmOrd.Text = "Complete Order";
            }
        }

        protected void BtnConfirmOrd_Click(object sender, EventArgs e)
        {
            bool saveCustomer, saveAdoption, updateAdoptionStat;
            customer.SetCustomerID();
            saveCustomer = DBconnection.SaveCustomerDetails(customer);
            pet.Adopted = true;
            updateAdoptionStat = DBconnection.UpdateAdoptedPetStatus(pet);
            DateTime currentDate = DateTime.Today;
            Adoption.GetMaxAdoptionID(); // determine what unique ID will be
            Adoption adoption = new Adoption(currentDate, customer, pet, amountGDP);
            saveAdoption = DBconnection.SaveAdoption(adoption);
            bool confirm = false;
            string message;
            if (saveCustomer == false)
            {
                message = "Error! Could not Save Customer";
            }
            else if (saveAdoption == false)
            {
                message = "Error! Could not Save Adoption";
            }
            else if (updateAdoptionStat == false)
            {
                message = "Error! Could not Update Pet status";
            }
            else // saveCustomer & saveAdoption both == true
            {
                message = "Customer and Adoption details saved successfully";
                confirm = true;
            }
            List<object> results = new List<object>();
            results.Add(confirm);
            results.Add(message);
            Session["ConfirmBoolString"] = results;
            Response.Redirect("Confirm_Page.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Adopt Pet.aspx");
        }
    }
}