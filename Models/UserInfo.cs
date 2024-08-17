using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id {get;set;}

        [Required(ErrorMessage ="Ad alanı zorunludur")]    
        public string? Name {get;set;}
        
        [Required(ErrorMessage ="Email alanı zorunludur")]
        [EmailAddress(ErrorMessage ="Geçerli bir mail adresi giriniz.")]
        public string? Email {get;set;}
        
        [Required(ErrorMessage ="Telefon alanı zorunludur")]
        public string? Phone {get;set;}
        
        [Required(ErrorMessage ="Seçim yapmak zorunludur")]
        public bool? WillAttend {get;set;}
    }

}