using System.ComponentModel.DataAnnotations;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Models
{
    public class RegisterFormModel
    {
        [MinLength(3), MaxLength(8)]
        public string FirstName { get; set; }

        [MinLength(3), MaxLength(8)]
        public string LastName { get; set; }

        [MinLength(5), MaxLength(8)]
        public string Password { get; set; }

        [MinLength(3), MaxLength(8)]
        public string City { get; set; }

        [StringLength(5)]
        public string PostCode { get; set; }

        [StringLength(6)]
        public string Phone { get; set; }

        [MinLength(3), MaxLength(8)]
        public string Address { get; set; }
    }
}