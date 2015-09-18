using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//Freeman A. Expert WebApi 
namespace MVC5TestRepo.Models
{
    public class GuestResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool? Attend { get; set; }
    }
}