﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Game_items_selling_web.Controllers.DBControllers;
using Game_items_selling_web.Models;

namespace Game_items_selling_web.Controllers
{
    public class Предметы_из_игрController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Предметы_из_игр
        public ActionResult Index(int id = -1, string role = "administrator")
        {
            ViewBag.id = id;
            ViewBag.role = role;
            if (id != -1 && role == "developer")
            {
                var предметы_из_игр = db.Предметы_из_игр.Where(a => a.Игры.Код_разработчика == id).Include(п => п.Валюты).Include(п => п.Игры);
                return View(предметы_из_игр.ToList());
            }
            else
            {
                var предметы_из_игр = db.Предметы_из_игр.Include(п => п.Валюты).Include(п => п.Игры);
                return View(предметы_из_игр.ToList());
            }
        }

        // GET: Предметы_из_игр/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Предметы_из_игр предметы_из_игр = db.Предметы_из_игр.Find(id);
            if (предметы_из_игр == null)
            {
                return HttpNotFound();
            }
            return View(предметы_из_игр);
        }

        // GET: Предметы_из_игр/Create
        public ActionResult Create(int id = -1, string role = "administrator")
        {
            ViewBag.id = id;
            ViewBag.Role = role;
            ViewBag.Буквенный_код_валюты = new SelectList(db.Валюты, "Буквенный_код_валюты", "Валюта");
            if (role == "developer")
            {
                ViewBag.Код_игры = new SelectList(db.Игры.Where(a => a.Код_разработчика == id), "Код_игры", "Игра");
            }
            else
            ViewBag.Код_игры = new SelectList(db.Игры, "Код_игры", "Игра");
            return View();
        }

        // POST: Предметы_из_игр/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_предмета,Код_игры,Игровой_предмет,Буквенный_код_валюты,Цена,Редкость,Количество")] Предметы_из_игр предметы_из_игр, int _id = -1, string _role = "administrator")
        {
            if (ModelState.IsValid)
            {
                db.Предметы_из_игр.Add(предметы_из_игр);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = _id, role = _role });
            }

            ViewBag.Буквенный_код_валюты = new SelectList(db.Валюты, "Буквенный_код_валюты", "Валюта", предметы_из_игр.Буквенный_код_валюты);
            ViewBag.Код_игры = new SelectList(db.Игры, "Код_игры", "Игра", предметы_из_игр.Код_игры);
            return View(предметы_из_игр);
        }

        // GET: Предметы_из_игр/Edit/5
        public ActionResult Edit(int? id, int _id = -1, string _role = "administrator")
        {
            ViewBag.id = _id;
            ViewBag.role = _role;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Предметы_из_игр предметы_из_игр = db.Предметы_из_игр.Find(id);
            if (предметы_из_игр == null)
            {
                return HttpNotFound();
            }
            ViewBag.Буквенный_код_валюты = new SelectList(db.Валюты, "Буквенный_код_валюты", "Валюта", предметы_из_игр.Буквенный_код_валюты);
            ViewBag.Код_игры = new SelectList(db.Игры, "Код_игры", "Игра", предметы_из_игр.Код_игры);
            return View(предметы_из_игр);
        }

        // POST: Предметы_из_игр/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_предмета,Код_игры,Игровой_предмет,Буквенный_код_валюты,Цена,Редкость,Количество")] Предметы_из_игр предметы_из_игр, int _id = -1, string _role = "administrator")
        {
            if (ModelState.IsValid)
            {
                db.Entry(предметы_из_игр).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = _id, role = _role });
            }
            ViewBag.Буквенный_код_валюты = new SelectList(db.Валюты, "Буквенный_код_валюты", "Валюта", предметы_из_игр.Буквенный_код_валюты);
            ViewBag.Код_игры = new SelectList(db.Игры, "Код_игры", "Игра", предметы_из_игр.Код_игры);
            return View(предметы_из_игр);
        }

        // GET: Предметы_из_игр/Delete/5
        public ActionResult Delete(int? id, int _id = -1, string _role = "administrator")
        {
            ViewBag.id = _id;
            ViewBag.role = _role;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Предметы_из_игр предметы_из_игр = db.Предметы_из_игр.Find(id);
            if (предметы_из_игр == null)
            {
                return HttpNotFound();
            }
            return View(предметы_из_игр);
        }

        // POST: Предметы_из_игр/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int _id = -1, string _role = "administrator")
        {
            Предметы_из_игр предметы_из_игр = db.Предметы_из_игр.Find(id);
            db.Предметы_из_игр.Remove(предметы_из_игр);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = _id, role = _role });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Excel(int _id = -1, string _role = "administrator")
        {
            System.Data.DataTable list = new System.Data.DataTable();
            for (int i = 0; i < 9; i++)
            { list.Columns.Add(); }
            if (_role == "administrator" || _role == "trader")
            {
                foreach (Предметы_из_игр item in db.Предметы_из_игр)
                {
                    list.Rows.Add(
                        item.Код_предмета,
                        item.Игровой_предмет,
                        item.Редкость,
                        item.Валюты.Валюта,
                        item.Цена,
                        item.Количество,
                        item.Игры.Игра,
                        item.Чек.Count);
                }
            }
            if (_role == "developer")
            {
                foreach (Игры game in db.Игры)
                {
                    if (game.Код_разработчика == _id)
                    {
                        foreach (Предметы_из_игр item in game.Предметы_из_игр)
                        {
                            list.Rows.Add(
                                item.Код_предмета,
                                item.Игровой_предмет,
                                item.Редкость,
                                item.Валюты.Валюта,
                                item.Цена,
                                item.Количество,
                                item.Игры.Игра,
                                item.Чек.Count);
                        }
                    }
                }
            }
            Functions.Excel("game_items", list);
            return RedirectToAction("Index", new { id = _id, role = _role });
        }
        public ActionResult Order(int _id, string _role, int? number, int game_id)
        {
            if (number != null && number > 0)
            {
                Предметы_из_игр gameitem = db.Предметы_из_игр.FirstOrDefault(a => a.Код_предмета == game_id);
                Торговые_площадки trader = db.Торговые_площадки.FirstOrDefault(a => a.Код_торговой_площадки == _id);
                if (gameitem.Количество >= number)
                {
                    Чек order = new Чек
                    {
                        Дата = DateTime.Now,
                        Кол_во_предметов = (int)number.Value,
                        Торговые_площадки = trader
                    };
                    gameitem.Чек.Add(order);
                    gameitem.Количество -= (int)number.Value;
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index", new { id = _id, role = _role });
        }
    }
}
