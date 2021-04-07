using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse  //POCO -Plain Old C# Object
    {

        //Fields & Properties
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; } // Property

        [Required(ErrorMessage = "Email Address Is Required")]
        [EmailAddress]
        public string Email { get; set; } // Property

        [Required(ErrorMessage = "Phone Number Is Required")]
        public string Phone { get; set; } // Property

        [Required(ErrorMessage = "Please Let Us Know If You Will Attend Or Not")]
        public bool? WillAttend { get; set; } // Property(true, false, or null)


        //Constructors

        //Methods 
    }
}
