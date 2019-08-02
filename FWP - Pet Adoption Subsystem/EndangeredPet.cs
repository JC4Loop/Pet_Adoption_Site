using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FWP___Pet_Adoption_Subsystem
{
    public class EndangeredPet : Pet
    {
        private string ePetID;
        private string imageString;

        /// <summary>
        /// Endangered (E), Critically Endangered (CR), ExtinctintheWild (EW)
        /// </summary>
        private string endangeredCategory;

        public EndangeredPet(string i, string n, string g, int a, DateTime r, string s, string b, string sanc, bool ad, string epi, string ec)
            : base(i,n,g,a,r,s,b,sanc,ad)
        {
            this.ePetID = epi;
            this.endangeredCategory = ec;            
        }

        public string EndangCategString()
        {
            string e;
            if(endangeredCategory == "E")
            {
                e = "Endangered";
            }
            else if(endangeredCategory == "CR")
            {
                e = "Critically Endangered";
            }
            else if (endangeredCategory == "EW")
            {
                e = "Extinct in the Wild";
            }
            else
            {
                e = "error!";
            }
            return e;
        }

        public static double EndangeredDeposit(Pet p)
        {
            double minDeposit;
            switch (p.Breed)
            {
                case "Barbary Lion":
                    minDeposit = 500;
                    break;
                case "Siberian Tiger":
                case "Bengal Tiger":
                    minDeposit = 350;
                    break;
                case "Amur Leopard":
                    minDeposit = 400;
                    break;
                case "Red-Breasted Goose":
                    minDeposit = 300;
                    break;
                default:
                    minDeposit = 0;
                    break;
            }
            return minDeposit;
        }

        public string GetImageString()
        {
            if (breed == "Barbary Lion")
            {
                imageString = "BL";
            } 
            else if (breed == "Siberian Tiger")
            {
                imageString = "ST";
            }
            else if (breed == "Bengal Tiger")
            {
                imageString = "BT";
            }
            else if (breed == "Amur Leopard")
            {
                imageString = "AL";
            }
            else if (breed == "Red-Breasted Goose")
            {
                imageString = "RG";
            }
            else
            {
                imageString = "";
            }
            return imageString;
        }

        public override string GetDetailLines()
        {
            return "(is an Endangered Pet)";
        }
    }
}