using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace FWP___Pet_Adoption_Subsystem
{
    public class DBconnection
    {
        private static OleDbConnection GetConnection()
        {
            string connString;
            // Location of database file - Couldn't set correct path without adding full path, so this will need editing when changing location
            connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\justin\OneDrive\My Documents\Code\VSProjects\FWP - Pet Adoption Subsystem\PetAdopDb.accdb";
            //connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|/PetAdopDB.accdb; Persist Security Info=False;";

            return new OleDbConnection(connString);
        }

        public static List<EndangeredPet> LoadEndangeredPets()
        {
            List<EndangeredPet> epList = new List<EndangeredPet>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Pet.*, EndangeredPet.* FROM Pet INNER JOIN EndangeredPet ON"
                                             + " Pet.Pet_ID = EndangeredPet.PetID";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {   
                        DateTime dt = Convert.ToDateTime(myReader["Rescue Date"].ToString());

                        EndangeredPet p = new EndangeredPet(myReader["Pet_ID"].ToString(), myReader["Name"].ToString(),
                            myReader["Gender"].ToString(), int.Parse(myReader["Age at Rescue"].ToString()),
                            dt, myReader["Specie"].ToString(), myReader["Breed"].ToString(),
                            myReader["Sanctuary"].ToString(), Convert.ToBoolean(myReader["Adopted"]), myReader["EPetID"].ToString(), myReader["Category"].ToString());
                        epList.Add(p);
                }
                return epList;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception in LoadEndangeredPets " + e);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<Pet> LoadNonEndangPets()
        {
            List<Pet> pList = new List<Pet>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Pet.* FROM Pet LEFT JOIN EndangeredPet ON Pet.Pet_ID = EndangeredPet.PetID"
                             + " WHERE EndangeredPet.PetID IS NULL";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    DateTime dt = Convert.ToDateTime(myReader["Rescue Date"].ToString());

                    Pet p = new Pet(myReader["Pet_ID"].ToString(), myReader["Name"].ToString(),
                        myReader["Gender"].ToString(), int.Parse(myReader["Age at Rescue"].ToString()),
                        dt, myReader["Specie"].ToString(), myReader["Breed"].ToString(),
                        myReader["Sanctuary"].ToString(), Convert.ToBoolean(myReader["Adopted"]));
                    pList.Add(p);
                }
                return pList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<Pet> LoadAllPets()
        {
            List<Pet> allPets = new List<Pet>();
            OleDbConnection myConnection = GetConnection();
            List<EndangeredPet> ePets = LoadEndangeredPets();
            List<Pet> nonEPets = LoadNonEndangPets();
            foreach (Pet p in nonEPets)
            {
                allPets.Add(p);
            }
            foreach (Pet ep in ePets)
            {
                allPets.Add(ep);
            }
            return allPets;
        }

        public static List<Customer> LoadAllCustomers()
        {
            List<Customer> allCustomers = new List<Customer>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Customer";// All records in Customer table
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Customer c = new Customer(myReader["CustomerID"].ToString(), myReader["Name"].ToString(), myReader["Email"].ToString(), myReader["Add1"].ToString(), myReader["Add2"].ToString(), myReader["Country"].ToString(), myReader["TeleNum"].ToString());
                    allCustomers.Add(c);
                }
                return allCustomers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool SaveCustomerDetails(Customer c)
        {
            bool bConfirm;
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Customer(CustomerID, Name, Email, Add1, Add2, Country, TeleNum) " +
                       " VALUES ('" + c.CustomerID + "', '" + c.CName + "', '" + c.CEmail + "','" + c.CAdd1
                       + "','" + c.CAdd2 + "','" + c.CCountry + "','" + c.TeleNum+"')" ;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection); // creates a command using the myQuery query and Connection myConnection
            try
            {
                myConnection.Open();                       // opens connection
                myCommand.ExecuteNonQuery();              // execute command
                bConfirm = true;
            }
            catch (Exception) // if an Exception error
            {
                bConfirm = false;
            }
            finally // weather or not successful close the connection
            {
                myConnection.Close();
            }
            return bConfirm;
        }

        public static string GetLastCustomerID()
        {
            string ID = null;
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Max([CustomerID]) AS LastID FROM Customer";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    ID = (myReader["LastID"].ToString());

                }
                return ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static string GetLastAdoptionID()
        {
            string ID = null;
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Max([AdoptionID]) AS LastID FROM Adoption";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    ID = (myReader["LastID"].ToString());
                }
                return ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static bool SaveAdoption(Adoption a)
        {
            bool confirm;
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Adoption(AdoptionID, AdDate, CustomerID, PetID, Deposit) VALUES ('" + a.AdoptionID + "', '" + a.AdDate + "','" + a.Customer.CustomerID + "','" + a.Pet.PetID + "','" + a.Deposit + "')";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                confirm = true;
            }
            catch (Exception)
            {
                confirm = false;
            }
            finally
            {
                myConnection.Close();
            }
            return confirm;
        }

        public static bool UpdateAdoptedPetStatus(Pet p)
        {
            bool confirm;
            string yesNo;
            if (p.Adopted == false)
            {
                yesNo = "0";
            }
            else //p.Adopted == true
            {
                yesNo = "1";
            }
            OleDbConnection myConnection = GetConnection();

            int pID = Convert.ToInt32(p.PetID);
            string myQuery = "UPDATE Pet SET Pet.Adopted = '" + yesNo + "' WHERE ((Pet.Pet_ID) = " + pID + ")";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                confirm = true;
            }
            catch (Exception)
            {
                confirm = false;
            }
            finally
            {
                myConnection.Close();
            }
            return confirm;
        }

        public static List<Adoption> LoadAllAdoptions()
        {
            List<Adoption> allAdoptions = new List<Adoption>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Adoption";// All records in Pet table
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                List<Customer> allCustomers = LoadAllCustomers();
                List<Pet> allPets = LoadAllPets();
                string cID , pID;
                while (myReader.Read())
                {
                    cID = myReader["CustomerID"].ToString();
                    pID = myReader["PetID"].ToString();
                    Customer c = allCustomers.Find(x => x.CustomerID == cID); // get customer using customerID
                    Pet p = allPets.Find(x => x.PetID == pID);                // get pet using petID
                    
                    DateTime adt = (DateTime) myReader["AdDate"];
                    bool terminated = (bool) myReader["Terminated"];
                    Adoption a;
                    if (terminated == true)
                    {
                        DateTime tDate = (DateTime)myReader["TerminationDate"];
                        a = new Adoption(myReader["AdoptionID"].ToString(), adt, c, p, Convert.ToDouble(myReader["Deposit"]), terminated, tDate);
                    }
                    else
                    {
                        a = new Adoption(myReader["AdoptionID"].ToString(), adt, c, p, Convert.ToDouble(myReader["Deposit"]), terminated);
                    }
                   
                    allAdoptions.Add(a);
                }
                return allAdoptions;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<object> LogInStaff(string sName, string password)
        {
            List<object> returnGenList = new List<object>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Staff";// All records in Pet table
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            bool dbSuccess;
            bool loginSuccess = false;
            string readUserName = null;
            string readPassword = null;
            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        readUserName = myReader["StaffUserName"].ToString();
                        if (readUserName == sName)
                        {
                            readPassword = myReader["Password"].ToString();
                            if (readPassword == password)
                            {
                                dbSuccess = true;
                                loginSuccess = true;
                                break; // user found so break out of loop
                            } // end of (if password does match)
                            else
                            {
                                loginSuccess = false;
                            } // end of (if password does not match)
                        } // end of (if userName does match)
                        else
                        { //if username does not match
                            loginSuccess = false;
                            readUserName = null;
                            readPassword = null;
                        }
                    } // end of while loop

                dbSuccess = true;
                returnGenList.Add(dbSuccess);       //List[0] = database bool
                returnGenList.Add(loginSuccess);    //List[1] = login bool
                returnGenList.Add(readUserName);    //List[2] = UserName
                returnGenList.Add(readPassword);    //List[3] = Password
                return returnGenList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return returnGenList;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<object> UpdateTerminateAdoption(Adoption adoption)
        {
            bool confirm;
            string msg;
            string yesNo;
            if (adoption.Terminated == false)
            {
                yesNo = "0"; // this isn't actually needed as we dont terminate an adoption when 
                             // adoption.Terminate == false
            }
            else //adopttion.Terminated == true
            {
                yesNo = "1";
            }
            OleDbConnection myConnection = GetConnection();
     
            string date = adoption.TerminDate.Day.ToString();
            string month = adoption.TerminDate.Month.ToString();
            string year = adoption.TerminDate.Year.ToString();
            string aID = adoption.AdoptionID;
            //                UPDATE Adoption SET Adoption.Terminated = '1'            , Adoption.TerminationDate = #     2013/11/12#                                 WHERE(((Adoption.AdoptionID) = '3'));
            string myQuery = "UPDATE Adoption SET Adoption.Terminated = '" + yesNo + "', Adoption.TerminationDate = #" + year + "/" + month + "/" + date + "# WHERE ((Adoption.AdoptionID) = '" + aID + "')";
         // string myQuery = "UPDATE Pet     SET          Pet.Adopted = '" + yesNo + "'                                                                       WHERE ((Pet.Pet_ID)          = " + pID + ")";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                confirm = true;
                msg = "Adoption successfully terminated";
            }
            catch (Exception e)
            {
                confirm = false;
                msg = "Failed to terminate adoption " + e;
            }
            finally
            {
                myConnection.Close();
            }
            List<object> terminateAdResults = new List<object>();
            terminateAdResults.Add(confirm);
            terminateAdResults.Add(msg);
            return terminateAdResults;
        }
    }
}