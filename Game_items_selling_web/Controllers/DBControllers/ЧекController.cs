using System;
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
    public class ЧекController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Чек
        public ActionResult Index(int id = -1, string role = "administrator")
        {
            ViewBag.id = id;
            ViewBag.role = role;
            if (id != -1 && role == "developer")
            {
                var чек = db.Чек.Where(a => a.Предметы_из_игр.Игры.Код_разработчика == id).Include(ч => ч.Предметы_из_игр).Include(ч => ч.Торговые_площадки);
                return View(чек.ToList());
            }
            else if (id != -1 && role == "trader")
            {
                var чек = db.Чек.Where(a=>a.Торговые_площадки.Код_торговой_площадки == id).Include(ч => ч.Предметы_из_игр).Include(ч => ч.Торговые_площадки);
                return View(чек.ToList());
            }
            else
            {
                var чек = db.Чек.Include(ч => ч.Предметы_из_игр).Include(ч => ч.Торговые_площадки);
                return View(чек.ToList());
            }
        }

        // GET: Чек/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Чек чек = db.Чек.Find(id);
            if (чек == null)
            {
                return HttpNotFound();
            }
            return View(чек);
        }

        // GET: Чек/Create
        public ActionResult Create()
        {
            ViewBag.Код_предмета = new SelectList(db.Предметы_из_игр, "Код_предмета", "Игровой_предмет");
            ViewBag.Код_фирмы = new SelectList(db.Торговые_площадки, "Код_торговой_площадки", "Торговая_площадка");
            return View();
        }

        // POST: Чек/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_чека,Код_фирмы,Код_предмета,Дата,Кол_во_предметов")] Чек чек)
        {
            if (ModelState.IsValid)
            {
                db.Чек.Add(чек);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Код_предмета = new SelectList(db.Предметы_из_игр, "Код_предмета", "Игровой_предмет", чек.Код_предмета);
            ViewBag.Код_фирмы = new SelectList(db.Торговые_площадки, "Код_торговой_площадки", "Торговая_площадка", чек.Код_фирмы);
            return View(чек);
        }

        // GET: Чек/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Чек чек = db.Чек.Find(id);
            if (чек == null)
            {
                return HttpNotFound();
            }
            ViewBag.Код_предмета = new SelectList(db.Предметы_из_игр, "Код_предмета", "Игровой_предмет", чек.Код_предмета);
            ViewBag.Код_фирмы = new SelectList(db.Торговые_площадки, "Код_торговой_площадки", "Торговая_площадка", чек.Код_фирмы);
            return View(чек);
        }

        // POST: Чек/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_чека,Код_фирмы,Код_предмета,Дата,Кол_во_предметов")] Чек чек)
        {
            if (ModelState.IsValid)
            {
                db.Entry(чек).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Код_предмета = new SelectList(db.Предметы_из_игр, "Код_предмета", "Игровой_предмет", чек.Код_предмета);
            ViewBag.Код_фирмы = new SelectList(db.Торговые_площадки, "Код_торговой_площадки", "Торговая_площадка", чек.Код_фирмы);
            return View(чек);
        }

        // GET: Чек/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Чек чек = db.Чек.Find(id);
            if (чек == null)
            {
                return HttpNotFound();
            }
            return View(чек);
        }

        // POST: Чек/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Чек чек = db.Чек.Find(id);
            db.Чек.Remove(чек);
            db.SaveChanges();
            return RedirectToAction("Index");
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
            for (int i = 0; i < 10; i++)
            { list.Columns.Add(); }
            if (_role == "administrator")
            {
                    foreach (var order in db.Чек)
                    {
                        list.Rows.Add(
                            order.Код_чека,
                            order.Торговые_площадки.Торговая_площадка,
                            order.Предметы_из_игр.Игровой_предмет,
                            order.Предметы_из_игр.Игры.Игра,
                            order.Предметы_из_игр.Игры.Разработчики.Разработчик,
                            order.Дата,
                            order.Кол_во_предметов,
                            order.Кол_во_предметов * order.Предметы_из_игр.Цена,
                            order.Предметы_из_игр.Валюты.Валюта);
                    }
            }
            else if (_role == "developer")
            {
                foreach (Игры game in db.Игры)
                {
                    if (game.Код_разработчика == _id)
                    {
                        foreach (Предметы_из_игр gameitem in game.Предметы_из_игр)
                        {
                            foreach (Чек order in gameitem.Чек)
                            {
                                list.Rows.Add(
                                    order.Код_чека,
                                    order.Торговые_площадки.Торговая_площадка,
                                    order.Предметы_из_игр.Игровой_предмет,
                                    order.Предметы_из_игр.Игры.Игра,
                                    order.Предметы_из_игр.Игры.Разработчики.Разработчик,
                                    order.Дата,
                                    order.Кол_во_предметов,
                                    order.Кол_во_предметов * order.Предметы_из_игр.Цена,
                                    order.Предметы_из_игр.Валюты.Валюта);
                            }
                        }
                    }
                }
            }
            else if (_role == "trader")
            {
                foreach (Торговые_площадки trader in db.Торговые_площадки)
                {
                    if (trader.Код_торговой_площадки == _id)
                    {
                        foreach (Чек order in trader.Чек)
                        {
                            list.Rows.Add(
                                order.Код_чека,
                                order.Торговые_площадки.Торговая_площадка,
                                order.Предметы_из_игр.Игровой_предмет,
                                order.Предметы_из_игр.Игры.Игра,
                                order.Предметы_из_игр.Игры.Разработчики.Разработчик,
                                order.Дата,
                                order.Кол_во_предметов,
                                order.Кол_во_предметов * order.Предметы_из_игр.Цена,
                                order.Предметы_из_игр.Валюты.Валюта);
                        }
                    }
                }
            }
            Functions.Excel("orders", list);
            return RedirectToAction("Index", new { id = _id, role = _role });
        }
    }
}
