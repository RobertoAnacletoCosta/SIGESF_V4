using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SIGESF.Models;

namespace Areas.Administracao.Controllers
{
    public class SolicitacaoSuprimentoFundosController : Controller
    {
        private ContextoEF db = new ContextoEF();

        // GET: Administracao/SolicitacaoSuprimentoFundos
        public ActionResult Index()
        {
            var solicitacoesSF = db.SolicitacoesSF.Include(s => s.AgenteSuprido);
            return View(solicitacoesSF.ToList());
        }

        // GET: Administracao/SolicitacaoSuprimentoFundos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolicitacaoSuprimentoFundos solicitacaoSuprimentoFundos = db.SolicitacoesSF.Find(id);
            if (solicitacaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            return View(solicitacaoSuprimentoFundos);
        }

        // GET: Administracao/SolicitacaoSuprimentoFundos/Create
        public ActionResult Create()
        {
            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome");
            return View();
        }

        // POST: Administracao/SolicitacaoSuprimentoFundos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SolicitacaoSuprimentoFundos solicitacaoSuprimentoFundos)
        {
            if (ModelState.IsValid)
            {
                db.SolicitacoesSF.Add(solicitacaoSuprimentoFundos);
                db.SaveChanges();
                TempData["Mensagem"] = "Cadastro efetuado com sucesso!";
                return RedirectToAction("Index");
            }

            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome", solicitacaoSuprimentoFundos.AgenteSupridoId);
            return View(solicitacaoSuprimentoFundos);
        }

        // GET: Administracao/SolicitacaoSuprimentoFundos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolicitacaoSuprimentoFundos solicitacaoSuprimentoFundos = db.SolicitacoesSF.Find(id);
            if (solicitacaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome", solicitacaoSuprimentoFundos.AgenteSupridoId);
            return View(solicitacaoSuprimentoFundos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SolicitacaoSuprimentoFundos solicitacaoSuprimentoFundos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(solicitacaoSuprimentoFundos).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Mensagem"] = "Atualizações efetuadas com sucesso!";
                return RedirectToAction("Index");
            }
            ViewBag.AgenteSupridoId = new SelectList(db.AgentesSupridos, "AgenteSupridoId", "Nome", solicitacaoSuprimentoFundos.AgenteSupridoId);
            return View(solicitacaoSuprimentoFundos);
        }

        // GET: Administracao/SolicitacaoSuprimentoFundos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolicitacaoSuprimentoFundos solicitacaoSuprimentoFundos = db.SolicitacoesSF.Find(id);
            if (solicitacaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            return View(solicitacaoSuprimentoFundos);
        }

        // POST: Administracao/SolicitacaoSuprimentoFundos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SolicitacaoSuprimentoFundos solicitacaoSuprimentoFundos = db.SolicitacoesSF.Find(id);
            db.SolicitacoesSF.Remove(solicitacaoSuprimentoFundos);
            db.SaveChanges();
            TempData["Mensagem"] = "Exclusão efetuada com sucesso!";
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