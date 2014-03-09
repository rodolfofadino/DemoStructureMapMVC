using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacaoDemo.Controllers
{
    public class LivroController : Controller
    {
        public ActionResult Index()
        {
            var repository = new Repository.LivroRepository();
            var livros = repository.GetAll();

            return View(livros);
        }
	}
}