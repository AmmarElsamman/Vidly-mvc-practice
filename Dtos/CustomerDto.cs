using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        //make our column name not nullable
        // the parameter given is to overwrite the error message
        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)] //set max length of chars equal to 255
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}