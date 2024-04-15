using Microsoft.AspNetCore.Mvc;
using Thuan2180605993.Data;
using Thuan2180605993.Models.Entites;

namespace Thuan2180605993.Controllers
{
	public class AdminController : Controller
	{
		private readonly ApplicationDbContext dbContext;

		public AdminController(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public IActionResult Login()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Login(Admin admin)
		{
			var myAdmin = dbContext.Admin.Where(x => x.Username == admin.Username && x.Passwords == admin.Passwords).FirstOrDefault();
			if(myAdmin != null)
			{
				// Lưu dữ liệu trên session đảm bảo tính bảo mật. Session nằm ở phía máy chủ
				HttpContext.Session.SetString("AdminSession", myAdmin.Name);
				return RedirectToAction("Dashboard");
			}
			else
			{
				ViewBag.Message = "Đăng nhập thất bại...";
			}
			return View();

		}

		public IActionResult Dashboard()
		{
			if (HttpContext.Session.GetString("AdminSession") != null)
			{
				ViewBag.MySession = HttpContext.Session.GetString("AdminSession").ToString();

			}
			else
			{
				return RedirectToAction("Login");
			}
			return View();
		}

		public IActionResult Logout()
		{
			if (HttpContext.Session.GetString("AdminSession") != null)
			{
				HttpContext.Session.Remove("AdminSession");
				return RedirectToAction("Login");
			}
			return View();
		}

		public IActionResult Index()
		{
			return View();
		}

	}
}
