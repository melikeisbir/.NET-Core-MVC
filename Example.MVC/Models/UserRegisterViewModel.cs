using System.ComponentModel.DataAnnotations;

namespace Example.MVC.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage="Lütfen adınızı giriniz")]
		public string Adiniz { get; set; }
		[Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
		public string Soyadiniz { get; set; }
		
		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Lütfen şifreyi giriniz")]
		public string Password { get; set; }
		[Required(ErrorMessage= "Lütfen şifreyi giriniz")]
		[Compare("Password", ErrorMessage ="Şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; }
	}
}
