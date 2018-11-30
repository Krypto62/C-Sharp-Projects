using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Models
{
    public class Policy : CarInsuranceNewQuote
    {

        public int moTotal = 0;
        public int moBase = 50; //Start with a base of $50 / month.

        private readonly string pConnectionString = @"Data Source = BLUEBOY\SQLEXPRESS; Initial Catalog = Car_Insurance; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        public ActionResult NewPolicy(string firstName, string lastName, string emailAddress, string dateOfBirth, int carYear, string carMake, string carModel, string dUI, string coverage)
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Coverage from New_Quote";
            List<CarInsuranceNewQuote> newPolicies = new List<CarInsuranceNewQuote>();

            using (SqlConnection policyConnection = new SqlConnection(pConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, policyConnection);

                policyConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                    Id = Convert.ToInt32(reader["Id"]);
                    FirstName = reader["FirstName"].ToString();
                    LastName = reader["LastName"].ToString();
                    EmailAddress = reader["EmailAddress"].ToString();
                    DateOfBirth = reader["DateOfBirth"].ToString();
                    CarYear = Convert.ToInt32(reader["CarYear"]);
                    CarMake = reader["CarMake"].ToString();
                    CarModel = reader["CarModel"].ToString();
                    DUI = reader["DUI"].ToString();
                    Coverage = reader["Coverage"].ToString();


                //If the user is under 18, add $100 to the monthly total.
                if (Convert.ToDateTime("DateOfBirth").Date < Convert.ToDateTime("DateOfBirth").Date.AddYears(18))
                {
                    moTotal = moBase + 100;
                }

                //If the user is under 25, add $25 to the monthly total.
                if (Convert.ToDateTime("DateOfBirth").Date < Convert.ToDateTime("DateOfBirth").Date.AddYears(25))

                {
                    moTotal = moBase + 25;
                }

                //If the user is over 100, add $25 to the monthly total.
                if (Convert.ToDateTime("DateOfBirth").Date > Convert.ToDateTime("DateOfBirth").Date.AddYears(100))
                {
                    moTotal = moBase + 25;
                }

                else
                {
                    moTotal = moBase;
                }

                //If the car's year is before 2000, add $25 to the monthly total.
                if (CarYear < 2000)
                {
                    moTotal = moTotal + 25;
                }

                //If the car's year is after 2015, add $25 to the monthly total.
                if (CarYear > 2015)
                {
                    moTotal = moTotal + 25;
                }

                //If the car's Make is a Porsche, add $25 to the price.
                //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

                if (CarMake == "Porsche" || CarMake == "porsche")
                {
                    if (CarModel == "911 Carrera")
                    {
                        moTotal = moTotal + 50;
                    }
                    else
                    {
                        moTotal = moTotal + 25;
                    }
                }

                //Add $10 to the monthly total for every speeding ticket the user has.
                //if ()

                //If the user has ever had a DUI, add 25% to the total.
                if (DUI == "Yes" || DUI == "yes")
                {
                    double add25Percent = .25;
                    moTotal = moTotal + (moTotal * Convert.ToInt32(add25Percent));
                }

                //If it's full coverage, add 50% to the total.
                if (Coverage == "Full" || Coverage == "full")
                {
                    double add50Percent = .50;
                    moTotal = moTotal + (moTotal * Convert.ToInt32(add50Percent));
                }
            }
            return NewPolicy;
            //return View(); //Trying to have it populate NewPolicy.cshtml
        } 

    }
}