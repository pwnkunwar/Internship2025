using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyContactForm.Models
{
    public class EmergencyContact
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email  { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        public string Address { get; set; }
        public string SecondAddress { get; set; }
        [Required]
        public string City { get; set; }    
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
    }
}
