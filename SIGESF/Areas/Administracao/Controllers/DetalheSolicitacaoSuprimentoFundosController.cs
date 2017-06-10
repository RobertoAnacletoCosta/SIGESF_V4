using SIGESF.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SIGESF.Areas.Administracao.Controllers
{
    public class DetalheSolicitacaoSuprimentoFundosController : Controller
    {
        private ContextoEF db = new ContextoEF();

        // GET: Administracao/DetalheSolicitacaoSuprimentoFundos
        public ActionResult Index()
        {
            var detalheSolicitacoes = db.DetalheSolicitacoes.Include(d => d.NaturezasDespesas).Include(d => d.SolicitacaoSuprimentoFundos);
            return View(detalheSolicitacoes.ToList());
        }

        // GET: Administracao/DetalheSolicitacaoSuprimentoFundos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheSolicitacaoSuprimentoFundos detalheSolicitacaoSuprimentoFundos = db.DetalheSolicitacoes.Find(id);
            if (detalheSolicitacaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            return View(detalheSolicitacaoSuprimentoFundos);
        }

        // GET: Administracao/DetalheSolicitacaoSuprimentoFundos/Create
        public ActionResult Create()
        {
            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao");
            ViewBag.SolicitacaoSuprimentoFundosId = new SelectList(db.SolicitacoesSF, "SolicitacaoSuprimentoFundosId", "Proc_Proad");
            return View();
        }

        // POST: Administracao/DetalheSolicitacaoSuprimentoFundos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetalheSolicitacaoId,SolicitacaoSuprimentoFundosId,NaturezaDespesaId,ValorSolicitado")] DetalheSolicitacaoSuprimentoFundos detalheSolicitacaoSuprimentoFundos)
        {
            if (ModelState.IsValid)
            {
                db.DetalheSolicitacoes.Add(detalheSolicitacaoSuprimentoFundos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao", detalheSolicitacaoSuprimentoFundos.NaturezaDespesaId);
            ViewBag.SolicitacaoSuprimentoFundosId = new SelectList(db.SolicitacoesSF, "SolicitacaoSuprimentoFundosId", "Proc_Proad", detalheSolicitacaoSuprimentoFundos.SolicitacaoSuprimentoFundosId);
            return View(detalheSolicitacaoSuprimentoFundos);
        }

        // GET: Administracao/DetalheSolicitacaoSuprimentoFundos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheSolicitacaoSuprimentoFundos detalheSolicitacaoSuprimentoFundos = db.DetalheSolicitacoes.Find(id);
            if (detalheSolicitacaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao", detalheSolicitacaoSuprimentoFundos.NaturezaDespesaId);
            ViewBag.SolicitacaoSuprimentoFundosId = new SelectList(db.SolicitacoesSF, "SolicitacaoSuprimentoFundosId", "Proc_Proad", detalheSolicitacaoSuprimentoFundos.SolicitacaoSuprimentoFundosId);
            return View(detalheSolicitacaoSuprimentoFundos);
        }

        // POST: Administracao/DetalheSolicitacaoSuprimentoFundos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetalheSolicitacaoId,SolicitacaoSuprimentoFundosId,NaturezaDespesaId,ValorSolicitado")] DetalheSolicitacaoSuprimentoFundos detalheSolicitacaoSuprimentoFundos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalheSolicitacaoSuprimentoFundos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NaturezaDespesaId = new SelectList(db.NaturezasDespesas, "NaturezaDespesaId", "Descricao", detalheSolicitacaoSuprimentoFundos.NaturezaDespesaId);
            ViewBag.SolicitacaoSuprimentoFundosId = new SelectList(db.SolicitacoesSF, "SolicitacaoSuprimentoFundosId", "Proc_Proad", detalheSolicitacaoSuprimentoFundos.SolicitacaoSuprimentoFundosId);
            return View(detalheSolicitacaoSuprimentoFundos);
        }

        // GET: Administracao/DetalheSolicitacaoSuprimentoFundos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalheSolicitacaoSuprimentoFundos detalheSolicitacaoSuprimentoFundos = db.DetalheSolicitacoes.Find(id);
            if (detalheSolicitacaoSuprimentoFundos == null)
            {
                return HttpNotFound();
            }
            return View(detalheSolicitacaoSuprimentoFundos);
        }

        // POST: Administracao/DetalheSolicitacaoSuprimentoFundos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalheSolicitacaoSuprimentoFundos detalheSolicitacaoSuprimentoFundos = db.DetalheSolicitacoes.Find(id);
            db.DetalheSolicitacoes.Remove(detalheSolicitacaoSuprimentoFundos);
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
