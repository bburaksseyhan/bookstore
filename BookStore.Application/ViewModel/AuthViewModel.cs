using System.ComponentModel.DataAnnotations;

namespace BookStore.Application.ViewModel
{
    public class AuthViewModel
    {
        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}
