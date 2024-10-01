using System.ComponentModel.DataAnnotations;

namespace CoreCV.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Resim Url giriniz.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Kullanıcı adınızı giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifrenizi tekrar giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler eşleşmedi")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mail Adresinizi giriniz.")]
        public string Mail { get; set; } 
    }   
}
