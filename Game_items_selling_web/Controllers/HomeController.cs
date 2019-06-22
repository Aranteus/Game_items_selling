using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game_items_selling_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Administrator()
        {
            return View();
        }

        public ActionResult Trader()
        {
            return View();
        }

        public ActionResult Developer()
        {
            return View();
        }
        public ActionResult Adm_Help()
        {
            return View();
        }
        public ActionResult Dev_Help()
        {
            return View();
        }
        public ActionResult Trade_Help()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string login, string password)
        {
            if (login == "admin" && password == "admin")
            {
                return RedirectToAction("Administrator", "Home");
            }
            else { }
            return HttpNotFound("Логин или пароль введены неверно");
        }
    }
}