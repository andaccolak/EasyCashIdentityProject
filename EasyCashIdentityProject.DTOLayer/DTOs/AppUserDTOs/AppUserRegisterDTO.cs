using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DTOLayer.DTOs.AppUserDTOs
{
    public class AppUserRegisterDTO
    {
        //[Required(ErrorMessage = "Ad alanı zorunludur")]
        //[MaxLength(30, ErrorMessage= "max 30 karakter girilebilir")]
       
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
