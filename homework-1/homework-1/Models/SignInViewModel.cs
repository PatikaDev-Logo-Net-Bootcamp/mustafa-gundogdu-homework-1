using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;

namespace homework_1.Models
{
    public class SignInViewModel
    {
        
        
        
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Lütfen isim alanını boş bırakmayınız!")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen sadece harf kullanın.")]
        public string FirstName { get; set; }

       
        
        
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen soyad alanını boş bırakmayınız!")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen sadece harf kullanın.")]
        public string LastName { get; set; }

        
        
        
        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Lütfen email alanını boş bırakmayınız!")]
        [RegularExpression("^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A-Za-z]{2,})$", ErrorMessage = "Hatalı giriş tekrar deneyin. Örn: asd@fgh.com")]
        public string  Email{ get; set; }



        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre alanını boş bırakmayınız!")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "Geçersiz giriş. En az 1 büyük harf ve En az bir sayı olmalı!")]
        public string Password { get; set; }
    }
}


