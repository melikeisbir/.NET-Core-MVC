using Example.MVC.Core.Entities;
using Example.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Example.MVC.Controllers
{
	[AllowAnonymous] //bazı sayfalara authentic
					 //olmadan erişim sağlanamayacak
	public class LoginController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet] // asenkron metotlar kullanılacak
		public IActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignUp(UserRegisterViewModel p)
		{
			#region KULLANICI GİRİŞİ
			//var user = await _userManager.FindByEmailAsync("melike@melike.com");
			//var control = await _userManager.CheckPasswordAsync(user, "123Qwe_1x");
			//true ise OK, false ise HATALI GİRİŞ
			#endregion

			// KULLANICI OLUŞTURMA
			AppUser appUser = new AppUser()
			{
				Id = 0,
				Name = p.Adiniz,
				Surname = p.Soyadiniz,
				Email = p.Mail,
				UserName = p.UserName,
			};
			if (p.Password==p.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appUser, p.Password);
			
			
				if (result.Succeeded)
				{
					return RedirectToAction("SignIn");
				}
				else
				{
					foreach(var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			
			return View();
		}
		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}
		[HttpPost]
		public async Task <IActionResult> SignIn(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				else
				{
					return RedirectToAction("SignIn", "Login");
				}
			}
			return View();
		}
	}
}
