using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required] //make our column name not nullable
        [StringLength(255)] //set max length of chars equal to 255
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public string Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}