using System;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AfCentral_MVC.Models
{
    public class Facilitator
    {
        public int id {get;set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string Surname {get; set;}
        [Required]
        public string Email {get; set;}
        [Required]
        public int Contact {get;set;}

        
    }
}