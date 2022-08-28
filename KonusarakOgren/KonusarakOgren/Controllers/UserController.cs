using Core.Entity;
using Data;
using KonusarakOgren.Models;
using Manager.IService;
using Manager.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;


namespace KonusarakOgren.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        private readonly IUserService _UserService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _UserService = userService;
        }

        [Route("Giris")]
        public IActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public JsonResult UserInsert(User user)
        {
            User usr = _UserService.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
            if (usr == null)
            {
                User user1 = new User()
                {
                    NameSurname = user.NameSurname,
                    Email = user.Email,
                    Password = user.Password,
                    CreateDate = DateTime.Now,
                    Status = true,
                    UpdateDate = DateTime.Now
                };
                _UserService.Addservis(user1);
                return Json(new { success = "İşlem Başarılı", status = 200 });
            }
            else
            {
                return Json(new { success = "İşlem Başarısız", status = 401 });
            }
        }
        public JsonResult Login(User user)
        {
            User LoginUser =_UserService.GetAll().Where(x => x.Email == user.Email && x.Password==user.Password).FirstOrDefault();
            if (LoginUser!=null)
            {
                CookieOptions option2 = new CookieOptions();
                option2.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("giris", LoginUser.Id.ToString(), option2);
                return Json(new { success = "İşlem Başarılı", status = 200 });
            }
            else
            {
                return Json(new { success = "İşlem Başarısız", status = 401 });
            }
        }
    }
}
