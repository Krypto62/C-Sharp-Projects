using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source = BLUEBOY\SQLEXPRESS; Initial Catalog = Car_Insurance; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";


        //public ActionResult Test()
        //{
        //    return View(db.Home.ToList());
        //}

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult NewQuote(string firstName, string lastName, string emailAddress, string dateOfBirth, int carYear, string carMake, string carModel, string dUI, int tickets, string coverage)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                
                 int MoTotal = 0;
                 int moBase = 50; //Start with a base of $50 / month.
                

                //If the user is under 18, add $100 to the monthly total.
                if (Convert.ToDateTime(dateOfBirth).Date<Convert.ToDateTime(dateOfBirth).Date.AddYears(18))
                {
                    MoTotal = moBase + 100;
                }

                //If the user is under 25, add $25 to the monthly total.
                if (Convert.ToDateTime(dateOfBirth).Date<Convert.ToDateTime(dateOfBirth).Date.AddYears(25))

                {
                    MoTotal = moBase + 25;
                }

                //If the user is over 100, add $25 to the monthly total.
                if (Convert.ToDateTime(dateOfBirth).Date > Convert.ToDateTime(dateOfBirth).Date.AddYears(100))
                {
                    MoTotal = moBase + 25;
                }

                else
                {
                    MoTotal = moBase;
                }

                //If the car's year is before 2000, add $25 to the monthly total.
                if (carYear < 2000)
                {
                    MoTotal = MoTotal + 25;
                }

                //If the car's year is after 2015, add $25 to the monthly total.
                if (carYear > 2015)
                {
                    MoTotal = MoTotal + 25;
                }

                //If the car's Make is a Porsche, add $25 to the price.
                //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

                if (carMake == "Porsche" || carMake == "porsche")
                {
                    if (carModel == "911 Carrera")
                    {
                        MoTotal = MoTotal + 50;
                    }
                    else
                    {
                        MoTotal = MoTotal + 25;
                    }
                }

                //Add $10 to the monthly total for every speeding ticket the user has.
                int ticketFee = tickets * 10;
                MoTotal = MoTotal + ticketFee;

                //If the user has ever had a DUI, add 25% to the total.
                if (dUI == "Yes" || dUI == "yes")
                {
                    double add25Percent = .25;
                    MoTotal = MoTotal + (MoTotal * Convert.ToInt32(add25Percent));
                }

                //If it's full coverage, add 50% to the total.
                if (coverage == "Full" || coverage == "full")
                {
                    double add50Percent = .50;
                    MoTotal = MoTotal + (MoTotal * Convert.ToInt32(add50Percent));
                    NewPolicy();
                };
           
                string queryString = @"INSERT INTO New_Quote (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Tickets, Coverage) VALUES
                                        (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @DUI, @Tickets, @Coverage)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.VarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUI", SqlDbType.VarChar);
                    command.Parameters.Add("@Tickets", SqlDbType.Int);
                    command.Parameters.Add("@Coverage", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@DateOfBirth"].Value = dateOfBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@DUI"].Value = dUI;
                    command.Parameters["@Tickets"].Value = tickets;
                    command.Parameters["@Coverage"].Value = coverage;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
       }

        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Tickets, Coverage from New_Quote";
            List<CarInsuranceNewQuote> newQuotes = new List<CarInsuranceNewQuote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new CarInsuranceNewQuote
                    {
                        //Everything below shows up in the Admin View
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        DateOfBirth = reader["DateOfBirth"].ToString(),
                        CarYear = Convert.ToInt32(reader["CarYear"]),
                        CarMake = reader["CarMake"].ToString(),
                        CarModel = reader["CarModel"].ToString(),
                        DUI = reader["DUI"].ToString(),
                        Tickets = Convert.ToInt32(reader["Tickets"]),
                        Coverage = reader["Coverage"].ToString()
                    };
                    newQuotes.Add(quote);
                }
            }
            return View(newQuotes);
        }
        public ActionResult NewPolicy() //We'll set the ViewBag values in this action
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Tickets, Coverage from New_Quote";
            List<CarInsuranceNewQuote> newQuotes = new List<CarInsuranceNewQuote>();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                /*
                while (reader.Read())
                {
                    var quote = new CarInsuranceNewQuote
                    {
                        //Everything below shows up in the Admin View
                       
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        DateOfBirth = reader["DateOfBirth"].ToString(),
                        CarYear = Convert.ToInt32(reader["CarYear"]),
                        CarMake = reader["CarMake"].ToString(),
                        CarModel = reader["CarModel"].ToString(),
                        DUI = reader["DUI"].ToString(),
                        Tickets = Convert.ToInt32(reader["Tickets"]),
                        Coverage = reader["Coverage"].ToString()
                    };
                    newQuotes.Add(quote);
                }
            }*/
            return View(newQuotes);
            //ViewBag.Title = "Thank You For Your Information!";
            //ViewBag.Description = "Here is your new policy amount";

            //ViewBag.UserNow = new CarInsuranceNewQuote()
            //{
            //    FirstName = "firstName",
            //    LastName = "lastName",
            //};
            //return View();

        }
}

    }
}
        
    
