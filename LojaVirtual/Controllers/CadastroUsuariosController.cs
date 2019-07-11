using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LojaVirtual.Models;

namespace LojaVirtual.Controllers
{
    public class CadastroUsuariosController : Controller
    {
        private LojaVirtualContext db = new LojaVirtualContext();

        // GET: CadastroUsuarios
        public ActionResult Index()
        {
            return View(db.CadastroUsuarios.ToList());
        }

        // GET: CadastroUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroUsuario cadastroUsuario = db.CadastroUsuarios.Find(id);
            if (cadastroUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadastroUsuario);
        }

        // GET: CadastroUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUsuario,NomeCompleto,CPF,DataNascimento,Telefone")] CadastroUsuario cadastroUsuario)
        {
            if (ModelState.IsValid)
            {
                db.CadastroUsuarios.Add(cadastroUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadastroUsuario);
        }

        // GET: CadastroUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroUsuario cadastroUsuario = db.CadastroUsuarios.Find(id);
            if (cadastroUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadastroUsuario);
        }

        // POST: CadastroUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUsuario,NomeCompleto,CPF,DataNascimento,Telefone")] CadastroUsuario cadastroUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastroUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastroUsuario);
        }

        // GET: CadastroUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroUsuario cadastroUsuario = db.CadastroUsuarios.Find(id);
            if (cadastroUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadastroUsuario);
        }

        // POST: CadastroUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadastroUsuario cadastroUsuario = db.CadastroUsuarios.Find(id);
            db.CadastroUsuarios.Remove(cadastroUsuario);
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
    }
}
