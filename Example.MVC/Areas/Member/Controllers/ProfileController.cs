using Example.MVC.Areas.Member.Models;
using Example.MVC.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace Example.MVC.Areas.Member.Controllers
{
	[Area("Member")]

	[Route("Member/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
		[HttpGet]

        public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel userEditViewModel =new UserEditViewModel();
			userEditViewModel.name = values.Name;
			userEditViewModel.surname=values.Surname;
			userEditViewModel.mail = values.Email; //şifre kısmı yazılmadığı için yazmadık
			return View(userEditViewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel p)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			user.Name = p.name;
			user.Surname = p.surname;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
			var result = await _userManager.UpdateAsync(user);
			if(result.Succeeded)
			{
				return RedirectToAction("SignIn", "Login");
			}
			return View();

		}

	}
}
