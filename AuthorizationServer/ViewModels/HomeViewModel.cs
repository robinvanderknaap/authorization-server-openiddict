using System.ComponentModel.DataAnnotations;

namespace AuthorizationServer.ViewModels
{
    public class HomeViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}