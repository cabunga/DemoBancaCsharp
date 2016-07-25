using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class UsuarioController : Controller
    {
        Usuario usuario;
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autenticarse(string usuario, string password)
        {
            return View();
        }
    }
}