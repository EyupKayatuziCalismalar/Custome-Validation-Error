using System.ComponentModel.DataAnnotations;
using WebApplication3.Models.CustomerValidation;

namespace WebApplication3.Models
{
    public class Kayit
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " Name girişi zorunludur")]
        [Display(Name = "İsim")]
        [MaxLength(50, ErrorMessage = "Girilen isim 50 veya 50 karakterden az olmalıdır")]
        [MinLength(2, ErrorMessage = "Girilen isim en az 2 karakterden oluşmalıdır.")]
        
        public string Name { get; set; }

        [Required(ErrorMessage = " Name2 girişi zorunludur")]
        [EmailClassValidation(ErrorMessage = "Hata")]
        
        public string Mail { get; set; }
        public string IdenficationNumber { get; set; }   
        public string UserCode { get; set; }   
        public int Age { get; set; }   
        public string Password { get; set; }   
        public string RepeatPassword { get; set; }   
    }
}
