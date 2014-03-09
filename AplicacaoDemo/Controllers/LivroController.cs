using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacaoDemo.Repository;

namespace AplicacaoDemo.Controllers
{
    public class LivroController : Controller
    {
        private ILivroRepository _repository;

        public LivroController(ILivroRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var livros = _repository.GetAll();

            if (!livros.Any())
                return View("SemLivros");

            return View(livros);
        }
	}
}