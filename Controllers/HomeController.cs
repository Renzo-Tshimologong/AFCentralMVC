using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AfCentral_MVC.Models;
using System.Data.SqlClient;
using System.Data;

namespace AfCentral_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public  ActionResult form1(Facilitator facilitator)
        {
            var model = new List<Facilitator>();
            if(ModelState.IsValid)
            {
                string con = "Server=sylvorenzo-latitude-D630;Database=AfCentral;User Id=sa;Password=Jacques@28;";
                
                using(SqlConnection connection = new SqlConnection(con))
                {
                    
                    
                    SqlCommand cmd2 = new SqlCommand("AddFacilitator",connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@name", facilitator.Name);
                    cmd2.Parameters.AddWithValue("@surname", facilitator.Surname);
                    cmd2.Parameters.AddWithValue("@email", facilitator.Email);
                    cmd2.Parameters.AddWithValue("@contact", facilitator.Contact);
                    connection.Open();
                    cmd2.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    string query = "SELECT * FROM facilitators";
                    SqlCommand cmd = new SqlCommand(query,connection);
                    
                    
                    using(SqlDataReader dataReader = cmd.ExecuteReader()){
                         
                        while(dataReader.Read()){
                            var name = dataReader["name"].ToString();
                            var surname = dataReader["Surname"].ToString();
                            var email = dataReader["Email"].ToString();
                            var contact = dataReader["Contact"].ToString();
                            var id = dataReader["facilitatorId"].ToString();

                            model.Add(new Facilitator
                            {Name = name,
                            Surname = surname,
                            Email = email,
                            Contact = int.Parse(contact),
                            id = int.Parse(id)
                            });
                           
      

                            
                        }
                        
                        
                    }

                }
                return View(model);
            }
            return View("Index");
        }
    }
}
