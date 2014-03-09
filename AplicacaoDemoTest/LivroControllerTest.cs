using System;
using System.Collections.Generic;
using AplicacaoDemo.Models;
using AplicacaoDemo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AplicacaoDemoTest
{
    [TestClass]
    public class LivroControllerTest
    {
        [TestMethod]
        public void ValidaARegraQuandoNaoTemLivro()
        {
            var repositoryFake = new LivroRepositoryFake();
            var controller = new AplicacaoDemo.Controllers.LivroController(repositoryFake);
            var result = controller.Index() as ViewResult;

            Assert.AreEqual("SemLivros", result.ViewName);
        }

    }

    public class LivroRepositoryFake : ILivroRepository
    {
        public List<Livro> GetAll()
        {
            return new List<Livro>();
        }
    }

}
