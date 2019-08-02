using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FWP___Pet_Adoption_Subsystem
{
    public class Pet
    {
        protected string petID;
        protected string name;
        protected string gender;
        protected int ageAtRescue;
        protected DateTime rescueDate;
        protected string specie;
        protected string breed;
        protected string sanctuary;
        protected bool adopted;

        // Properties for fields (class variables)
        public string PetID
        {
            get { return petID; }
        }

        public string Name
        {
            get { return name; }
        }
        public string Gender
        {
            get { return gender; }
        }
        public int AgeAtRescue
        {
            get { return ageAtRescue; }
        }
        public DateTime RescueDate
        {
            get { return rescueDate; }
        }
        public string Specie
        {
            get { return specie; }
        }
        public string Breed
        {
            get { return breed; }
        }

        public string Sanctuary
        {
            get { return sanctuary; }
        }

        public bool Adopted
        {
            get { return adopted; }
            set { adopted = value; }
        }

        // Constructor for new Pet instance
        public Pet(string i, string n, string g, int a, DateTime r, string s, string b, string sanc, bool ad)
        {
            this.petID = i;
            this.name = n;
            this.gender = g;
            this.ageAtRescue = a;
            this.rescueDate = r;
            this.specie = s;
            this.breed = b;
            this.sanctuary = sanc;
            this.adopted = ad;
        }

        public static double CheckMinPetDeposit(Pet p)
        {
            double minDeposit;
            switch (p.specie)
            {
                case "Dog":
                    minDeposit = 100.00;
                    break;
                case "Cat":
                    minDeposit = 50.00;
                    break;
                case "Rabbit":
                    minDeposit = 30;
                    break;
                case "Ferret":         //Ferret is same minDeposit as Chinchilla so fall through
                case "Chinchilla":
                    minDeposit = 20;
                    break;
                case "Guinea Pig":
                    minDeposit = 15;
                    break;
                default:
                   // minDeposit = 0;
                    minDeposit = EndangeredPet.EndangeredDeposit(p);
                    break;
            }
            return minDeposit;
        }

        public virtual string GetDetailLines()
        {
            return "(is not an Endangered Pet)";
        }
    }
}