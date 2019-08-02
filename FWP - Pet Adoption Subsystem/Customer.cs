using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FWP___Pet_Adoption_Subsystem
{
    public class Customer // (Adopter)
    {
        private string customerID;
        private static int customerIDCounter;

        private string cName;
        private string cEmail;
        private string cAdd1;
        private string cAdd2;
        private string cCountry;
        private string teleNum;

        public string CustomerID
        {
            get { return customerID; }
           // set { customerID = value; } // Don't need, made custom set method below
        }

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }

        public string CEmail
        {
            get { return cEmail; }
            set { cEmail = value; }
        }

        public string CAdd1
        {
            get { return cAdd1; }
            set { cAdd1 = value; }
        }

        public string CAdd2
        {
            get { return cAdd2; }
            set { cAdd2 = value; }
        }

        public string CCountry
        {
            get { return cCountry; }
            set { cCountry = value; }
        }

        public string TeleNum
        {
            get { return teleNum; }
            set { teleNum = value; }
        }

        // Constructor for creating 'Customer' when reading from database
        public Customer(string cID, string n, string e, string a1, string a2, string c, string t)
        {
            this.customerID = cID; // ID will be read from database
            this.cName = n;
            this.cEmail = e;
            this.cAdd1 = a1;
            this.cAdd2 = a2;
            this.cCountry = c;
            this.teleNum = t;
        }

        // Constructor for creating 'Customer', not reading from database
        public Customer(string n, string e, string a1, string a2, string c, string t)
        {
            //this.customerID = (++customerIDCounter).ToString();
            this.cName = n;
            this.cEmail = e;
            this.cAdd1 = a1;
            this.cAdd2 = a2;
            this.cCountry = c;
            this.teleNum = t;
        }

        public void SetCustomerID()
        {
            customerIDCounter = Convert.ToInt32(DBconnection.GetLastCustomerID()); // get last ID
            customerID = (++customerIDCounter).ToString(); // set (incremented) ID 
        }
    }
}