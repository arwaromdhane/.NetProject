using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projet_net.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ajouterCategorie()
        {
            return View();
        }
    }
}