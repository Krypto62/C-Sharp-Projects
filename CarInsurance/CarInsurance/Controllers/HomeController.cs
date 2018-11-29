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


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewQuote(string firstName, string lastName, string emailAddress, string dateOfBirth, int carYear, string carMake, string carModel, string dUI, string coverage)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string queryString = @"INSERT INTO New_Quote (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Coverage) VALUES
                                        (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @DUI, @Coverage)";

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
                    command.Parameters.Add("@Coverage", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@DateOfBirth"].Value = dateOfBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@DUI"].Value = dUI;
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
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Coverage from New_Quote";
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
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        DateOfBirth = reader["DateOfBirth"].ToString(),
                        CarYear = Convert.ToInt32(reader["CarYear"]),
                        CarMake = reader["CarMake"].ToString(),
                        CarModel = reader["CarModel"].ToString(),
                        DUI = reader["DUI"].ToString(),
                        Coverage = reader["Coverage"].ToString()
                    };
                    newQuotes.Add(quote);
                }
            }
            return View(newQuotes);
        }
    }
}