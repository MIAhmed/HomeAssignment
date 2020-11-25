using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeAssignment.Models
{
    public class AppUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }


        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 4)]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage = "Email format is not correct.")]
        public string Email { get; set; }
        
       
        public string Password { get; set; }

        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        public string CompanyName { get; set; }

        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        public string Site { get; set; }
    }
}
