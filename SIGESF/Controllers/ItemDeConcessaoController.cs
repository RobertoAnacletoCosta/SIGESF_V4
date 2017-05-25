using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SIGESF.Models;

namespace SIGESF.Controllers
{
    public class ItemDeConcessaoController : Controller
    {
        private ContextoEF db = new ContextoEF();

        // GET: ItemDeConcessao
        public ActionResult Index()
        {
            var itemDeConcessaos = db.ItemDeConcessaos.Include(i => i.ConcessaoSuprimentoFundos).Include(i => i.NaturezaDespesa);
            return View(itemDeConcessaos.ToList());
        }

        // GET: ItemDeConcessao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemDeConcessao itemDeConcessao = db.ItemDeConcessaos.Find(id);
            if (itemDeConcessao == null)
            {
                return HttpNotFound();
            }
            return View(itemDeConcessao);
        }

        // GET: ItemDeConcessao/Create
        public ActionResult Create()
        {
            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.Concessoes, "ConcessaoSuprimentoFundosId", "ConcessaoSuprimentoFundosId");
            ViewBag.ItemDeConcessaoId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "CodigoDespesa");
            return View();
        }

        // POST: ItemDeConcessao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemDeConcessaoId,NaturezaDespesaId,ConcessaoSuprimentoFundosId,Valor")] ItemDeConcessao itemDeConcessao)
        {
            if (ModelState.IsValid)
            {
                db.ItemDeConcessaos.Add(itemDeConcessao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.Concessoes, "ConcessaoSuprimentoFundosId", "ConcessaoSuprimentoFundosId", itemDeConcessao.ConcessaoSuprimentoFundosId);
            ViewBag.ItemDeConcessaoId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "CodigoDespesa", itemDeConcessao.ItemDeConcessaoId);
            return View(itemDeConcessao);
        }

        // GET: ItemDeConcessao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemDeConcessao itemDeConcessao = db.ItemDeConcessaos.Find(id);
            if (itemDeConcessao == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.Concessoes, "ConcessaoSuprimentoFundosId", "ConcessaoSuprimentoFundosId", itemDeConcessao.ConcessaoSuprimentoFundosId);
            ViewBag.ItemDeConcessaoId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "CodigoDespesa", itemDeConcessao.ItemDeConcessaoId);
            return View(itemDeConcessao);
        }

        // POST: ItemDeConcessao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemDeConcessaoId,NaturezaDespesaId,ConcessaoSuprimentoFundosId,Valor")] ItemDeConcessao itemDeConcessao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemDeConcessao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConcessaoSuprimentoFundosId = new SelectList(db.Concessoes, "ConcessaoSuprimentoFundosId", "ConcessaoSuprimentoFundosId", itemDeConcessao.ConcessaoSuprimentoFundosId);
            ViewBag.ItemDeConcessaoId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "CodigoDespesa", itemDeConcessao.ItemDeConcessaoId);
            return View(itemDeConcessao);
        }

        // GET: ItemDeConcessao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemDeConcessao itemDeConcessao = db.ItemDeConcessaos.Find(id);
            if (itemDeConcessao == null)
            {
                return HttpNotFound();
            }
            return View(itemDeConcessao);
        }

        // POST: ItemDeConcessao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemDeConcessao itemDeConcessao = db.ItemDeConcessaos.Find(id);
            db.ItemDeConcessaos.Remove(itemDeConcessao);
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
