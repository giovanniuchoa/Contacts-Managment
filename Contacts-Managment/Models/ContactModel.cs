using System.ComponentModel.DataAnnotations;

namespace Contacts_Managment.Models
{
    public class ContactModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Name is missing")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is missing")]
        [EmailAddress(ErrorMessage = "Email is invalid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Number is missing")]
        [Phone(ErrorMessage = "Number is invalid")]
        public string Number { get; set; }

    }
}
