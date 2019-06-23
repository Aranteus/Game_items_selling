using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game_items_selling_web.Models;
using Game_items_selling_web.Controllers.DBControllers;

namespace Game_items_selling_web.Controllers
{
    public class HomeController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();
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

        public ActionResult Trader(string id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult Developer(string id)
        {
            ViewBag.id = id;
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
            else if (login != "" && password == "developer")
            {
                if (login.Contains("_") == true)
                {
                    string[] mas = login.Split('_');
                    if (mas.Length == 2)
                    {
                        if (Int32.TryParse(mas[0], out int id) == true)
                        {
                            string name = mas[1];
                            Разработчики dev = db.Разработчики.FirstOrDefault(a => a.Код_разработчика == id && a.Разработчик == name);
                            if (dev != null)
                            {
                                return RedirectToAction("Developer", "Home", new { id = id.ToString() } );
                            }
                            else return HttpNotFound("Логин или пароль введены неверно");
                        }
                        else return HttpNotFound("Логин или пароль введены неверно");
                    }
                    else return HttpNotFound("Логин или пароль введены неверно");
                }
                else return HttpNotFound("Логин или пароль введены неверно");                
            }
            else if (login != "" && password == "trader")
            {
                if (login.Contains("_") == true)
                {
                    string[] mas = login.Split('_');
                    if (mas.Length == 2)
                    {
                        if (Int32.TryParse(mas[0], out int id) == true)
                        {
                            string name = mas[1];
                            Торговые_площадки trader = db.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == id && a.Торговая_площадка == name);
                            if (trader != null)
                            {
                                return RedirectToAction("Trader", "Home", new { id = id.ToString() });
                            }
                            else return HttpNotFound("Логин или пароль введены неверно");
                        }
                        else return HttpNotFound("Логин или пароль введены неверно");
                    }
                    else return HttpNotFound("Логин или пароль введены неверно");
                }
                else return HttpNotFound("Логин или пароль введены неверно");
            }
            else return HttpNotFound("Логин или пароль введены неверно");
        }
    }
}