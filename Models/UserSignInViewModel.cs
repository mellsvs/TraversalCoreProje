
using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi Giriniz")]
        public string password { get; set; }
    }
}
