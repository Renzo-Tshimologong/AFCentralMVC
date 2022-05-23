using System;
using System.Data.SqlClient;
using AfCentral_MVC.Models;
using System.Collections.Generic;
using System.Data;

namespace AfCentral_MVC
{
    public class Services
    {
        public  object Connection(Facilitator facilitator)
        {
            var model = new List<Facilitator>();
             string con = "Server=SYLVORENZO;Database=AFCentral;Trusted_Connection = true;";
                
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
                    string query = "SELECT * FROM facilitator";
                    SqlCommand cmd = new SqlCommand(query,connection);
                    
                    
                    using(SqlDataReader dataReader = cmd.ExecuteReader()){
                         
                        while(dataReader.Read()){
                            var name = dataReader["Name"].ToString();
                            var surname = dataReader["Surname"].ToString();
                            var email = dataReader["Email"].ToString();
                            var contact = dataReader["Contact"].ToString();
                            var id = dataReader["FacilitatorID"].ToString();

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
                return model;

        }
    }
}