using System.ComponentModel.DataAnnotations;

namespace WebAppTemplate.ViewModels
{
    public class RegisterViewModel
    {

        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords do not match ")]
        public string PasswordConfirmation { get; set; }
    }
}
