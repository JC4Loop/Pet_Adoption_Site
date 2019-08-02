using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FWP___Pet_Adoption_Subsystem
{
    public class Adoption
    {
        private static int adoptIdCounter;
        private string adoptionID;
        private DateTime adDate;
        private Customer customer;
        private Pet pet;
        private double deposit;
        private bool terminated;
        private DateTime terminDate;

        public string AdoptionID
        {
            get { return adoptionID; }
            set { adoptionID = value; }
        }

        public DateTime AdDate
        {
            get { return adDate; }
            set { adDate = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Pet Pet
        {
            get { return pet; }
            set { pet = value; }
        }

        public double Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        public bool Terminated
        {
            get { return terminated; }
            set { terminated = value; }
        }

        public DateTime TerminDate
        {
            get { return terminDate; }
            set { terminDate = value; }
        }

        // Constructor for reading a terminated Adoption from database
        public Adoption(string aID, DateTime aD, Customer c, Pet p, double d, bool t, DateTime tD)
        {
            this.AdoptionID = aID;
            this.adDate = aD;
            this.customer = c;
            this.pet = p;
            this.deposit = d;
            this.terminated = t;
            this.terminDate = tD;
        }

        // Constructor for reading a Adoption from database without termination Date
        public Adoption(string aID, DateTime aD, Customer c, Pet p, double d, bool t)
        {
            this.AdoptionID = aID;
            this.adDate = aD;
            this.customer = c;
            this.pet = p;
            this.deposit = d;
            this.terminated = t;
        }

        // Constructor for creating new Adoption, (not reading from database)
        public Adoption(DateTime aD, Customer c, Pet p, double d)
        {
            this.AdoptionID = (++adoptIdCounter).ToString();
            this.adDate = aD;
            this.customer = c;
            this.pet = p;
            this.deposit = d;
            this.terminated = false;
        }

        /// <summary>
        /// Static class method (give instance reference)
        /// </summary>
        public static List<object> TerminateAdoption(Adoption a)
        {
            a.terminated = true;
            a.terminDate = DateTime.Now;
            List<object> l = DBconnection.UpdateTerminateAdoption(a);
            return l;
        }

        public static void GetMaxAdoptionID() // will need to be called before creating adoption with id set
        {
            adoptIdCounter = Convert.ToInt32(DBconnection.GetLastAdoptionID());
        }
    }
}