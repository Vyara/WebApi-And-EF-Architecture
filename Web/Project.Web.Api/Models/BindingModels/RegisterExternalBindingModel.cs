using System.ComponentModel.DataAnnotations;

namespace Project.Web.Api.Models
{
    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}