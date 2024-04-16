using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Thuan2180605993.Data;
using Thuan2180605993.Models.Entites;

namespace Thuan2180605993.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string passWord)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                // Perform authentication
                var customer = _context.Customer.FirstOrDefault(n => n.Username == userName && n.Passwords == passWord);
                if (customer != null)
                {
                    HttpContext.Session.SetString("usr", customer.ToString());
                    return RedirectToAction("Index", "AuraStore");
                }
            }
            ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var existingCustomer = _context.Customer.FirstOrDefault(a => a.Username == customer.Username);
                if (existingCustomer == null)
                {
                    _context.Add(customer);
                    _context.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản đã tồn tại !");
                    return View();
                }
            }
            return View(customer);
        }

        // Other action methods like Forgotpassword and Changepassword would follow a similar conversion pattern
        // Ensure you have the necessary using directives in place
    }
}
