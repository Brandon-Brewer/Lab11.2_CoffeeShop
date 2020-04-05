using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11._3_CoffeeShop.Models
{
    public class RegisterModel
    {
        private string firstName; 
        private string lastName; 
        private string email;
        private string phoneNumber;
        private string password;
        private string gender;
        private bool over21;
        private List<string> coffeeTypes;

        
        [DisplayName("First Name")] 
        [Required] 
        [MaxLength(20)] 
        [MinLength(2)] 
        public string FirstName { get => firstName; set => firstName = value; }  
 
        [DisplayName("Last Name")] 
        [Required] 
        [MaxLength(20)] 
        [MinLength(2)] 
        public string LastName { get => lastName; set => lastName = value; } 
 
        [DisplayName("E-mail")] 
        [EmailAddress] 
        [Required] 
        public string Email { get => email; set => email = value; }

        [DisplayName("Phone Number")]
        [Required]
        [MinLength(10)]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Password")]
        [Required]
        [MinLength(10)]
        public string Password { get => password; set => password = value; }

        [Required]
        public string Gender { get => gender; set => gender = value; }

        [Required]
        public bool Over21 { get => over21; set => over21 = value; }
    }
}
