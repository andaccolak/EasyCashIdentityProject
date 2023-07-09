using EasyCashIdentityProject.DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("soyad alanı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("kullanıcı adı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("şifre kısmı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("şifre kısmı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("en fazla 30 karakter girin");
            RuleFor(x => x.Name).MinimumLength(1).WithMessage("en az 2 karakter girin");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("şifreler eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("lütfen geçerli formatta bir mail giriniz");
        }
    }
}
