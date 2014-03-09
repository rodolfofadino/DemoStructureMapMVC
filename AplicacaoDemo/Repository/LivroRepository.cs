using System.Collections.Generic;
using AplicacaoDemo.Models;

namespace AplicacaoDemo.Repository
{
    public class LivroRepository
    {
        public List<Livro> GetAll()
        {
            var retorno=new List<Livro>
            {
                new Livro() {Id = 1, Titulo = "Madame Bovay", Autor = "Gustave Flaubert"},
                new Livro() {Id = 2, Titulo = "Guerra e Paz", Autor = "Leon Tolstoi"},
                new Livro() {Id = 3, Titulo = "Romeo and Juliet", Autor = "William Shakespeare"},
                new Livro() {Id = 4, Titulo = "O efeito sombra", Autor = "Marianne Williamson"},
                new Livro() {Id = 5,Titulo = "Professional ASP.NET MVC 4",Autor = "Galloway, Jon, Haack, Phil, Wilson, Brad and Allen"}
            };

            return retorno;
        }
    }
}