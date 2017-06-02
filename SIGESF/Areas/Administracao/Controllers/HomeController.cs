using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Administracao.Controllers
{    //Nesse controller apenas o perfil Administrador tem acesso. 
    //[Authorize(Roles = "Administrador")]
    public class HomeController : Controller
    {
        [Authorize(Roles = "Adinistrador")]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Detalhes()
        {
            return View();
        }
        [Authorize(Roles = "Usuário")]
        public ActionResult Usuarios()
        {
            return View();
        }
    }
}