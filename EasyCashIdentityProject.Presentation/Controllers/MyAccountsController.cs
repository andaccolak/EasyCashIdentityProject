using EasyCashIdentityProject.DTOLayer.DTOs.AppUserDTOs;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.Controllers
{
    [Authorize]
    public class MyAccountsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public MyAccountsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto= new AppUserEditDto();
            appUserEditDto.Name= values.Name;
            appUserEditDto.Email= values.Email;
            appUserEditDto.PhoneNumber= values.PhoneNumber;
            appUserEditDto.Surname = values.SurName;
            appUserEditDto.City = values.City;
            appUserEditDto.District = values.District; 
            appUserEditDto.ImageUrl = values.ImageUrl;
            return View(appUserEditDto);
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDto appUserEditDto)
        {
            if (appUserEditDto.Password == appUserEditDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.PhoneNumber = appUserEditDto.PhoneNumber;
                user.SurName = appUserEditDto.Surname;
                user.City = appUserEditDto.City;
                user.Name = appUserEditDto.Name;
                user.District = appUserEditDto.District;
                user.ImageUrl = "test";
                user.Email = appUserEditDto.Email;
                user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,appUserEditDto.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
