using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Game_items_selling_web.Models;
using Microsoft.Office.Interop.Excel;
using System.IO;
using Game_items_selling_web.Controllers.DBControllers;

namespace Game_items_selling_web.Controllers
{
    public class ИгрыController : Controller
    {
        private Game_items_tradingEntities db = new Game_items_tradingEntities();

        // GET: Игры
        public ActionResult Index(int id = -1, string role = "administrator")
        {
            ViewBag.id = id;
            ViewBag.role = role;
            if (id != -1 && role == "developer")
            {
                var games = db.Игры.Where(a => a.Код_разработчика == id).Include(и => и.Жанры).Include(и => и.Платформы).Include(и => и.Разработчики);
                return View(games.ToList());
            }
            else
            {
                var игры = db.Игры.Include(и => и.Жанры).Include(и => и.Платформы).Include(и => и.Разработчики);
                return View(игры.ToList());
            }
        }

        // GET: Игры/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Игры игры = db.Игры.Find(id);
            if (игры == null)
            {
                return HttpNotFound();
            }
            return View(игры);
        }

        // GET: Игры/Create
        public ActionResult Create(int id = -1, string role = "administrator")
        {
            ViewBag.id = id;
            ViewBag.Role = role;
            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр");
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа");
            if (id == -1)
                ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик");
            else
                ViewBag.Код_разработчика = new SelectList(db.Разработчики.Where(a => a.Код_разработчика == id), "Код_разработчика", "Разработчик");
            return View();
        }

        // POST: Игры/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_игры,Код_разработчика,Код_жанра,Код_платформы,Игра,Движок,Дата_создания")] Игры игры, int _id, string _role)
        {
            if (ModelState.IsValid)
            {
                db.Игры.Add(игры);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = _id, role = _role });
            }

            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр", игры.Код_жанра);
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа", игры.Код_платформы);
            ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик", игры.Код_разработчика);
            return View(игры);
        }

        // GET: Игры/Edit/5
        public ActionResult Edit(int? id, int _id = -1, string _role = "administrator")
        {
            ViewBag.id = _id;
            ViewBag.role = _role;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Игры игры = db.Игры.Find(id);
            if (игры == null)
            {
                return HttpNotFound();
            }
            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр", игры.Код_жанра);
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа", игры.Код_платформы);
            ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик", игры.Код_разработчика);
            return View(игры);
        }

        // POST: Игры/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_игры,Код_разработчика,Код_жанра,Код_платформы,Игра,Движок,Дата_создания")] Игры игры, int _id, string _role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(игры).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = _id, role = _role});
            }
            ViewBag.Код_жанра = new SelectList(db.Жанры, "Код_жанра", "Жанр", игры.Код_жанра);
            ViewBag.Код_платформы = new SelectList(db.Платформы, "Код_платформы", "Платформа", игры.Код_платформы);
            ViewBag.Код_разработчика = new SelectList(db.Разработчики, "Код_разработчика", "Разработчик", игры.Код_разработчика);
            return View(игры);
        }

        // GET: Игры/Delete/5
        public ActionResult Delete(int? id, int _id = -1, string _role = "administrator")
        {
            ViewBag.id = _id;
            ViewBag.role = _role;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Игры игры = db.Игры.Find(id);
            if (игры == null)
            {
                return HttpNotFound();
            }
            return View(игры);
        }

        // POST: Игры/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int _id = -1, string _role = "administrator")
        {
            Игры игры = db.Игры.Find(id);
            db.Игры.Remove(игры);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = _id, role = _role});
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Excel(int id_ = -1, string role_ = "administrator")
        {
            System.Data.DataTable list = new System.Data.DataTable();
            for (int i = 0; i < 12; i++)
            { list.Columns.Add(); }
            if (id_ == -1)
            {
                foreach (Игры game in db.Игры)
                {
                    foreach (Издатели p in game.Издатели)
                    {
                        foreach (Возрастной_рейтинг r in game.Возрастной_рейтинг)
                        {
                            list.Rows.Add(
                            game.Код_игры,
                            game.Игра,
                            game.Движок,
                            game.Дата_создания,
                            game.Платформы.Платформа,
                            game.Разработчики.Разработчик,
                            game.Жанры.Жанр,
                            p.Издатель,
                            r.Название_рейтинга,
                            r.Рейтинг,
                            game.Предметы_из_игр.Count());
                        }
                    }
                }
            }
            else
            {
                foreach (Игры game in db.Игры)
                {
                    if (game.Код_разработчика == id_)
                    {
                        foreach (Издатели p in game.Издатели)
                        {
                            foreach (Возрастной_рейтинг r in game.Возрастной_рейтинг)
                            {
                                list.Rows.Add(
                                game.Код_игры,
                                game.Игра,
                                game.Движок,
                                game.Дата_создания,
                                game.Платформы.Платформа,
                                game.Разработчики.Разработчик,
                                game.Жанры.Жанр,
                                p.Издатель,
                                r.Название_рейтинга,
                                r.Рейтинг,
                                game.Предметы_из_игр.Count());
                            }
                        }
                    }
                }
            }
            Functions.Excel("games", list);
            return RedirectToAction("Index", new {id = id_,  role = role_});            
        }
    }
}
