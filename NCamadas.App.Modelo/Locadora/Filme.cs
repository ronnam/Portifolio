using System;
using System.Collections.Generic;

namespace NCamadas.App.Modelo.Locadora
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Genero Genero { get; set; }
        public Classificacao Classificacao { get; set; }
        public DateTime Ano { get; set; }
        public decimal Preco { get; set; }

        public IList<FilmeLocacao> Locacoes { get; set; }
        public IList<UsuarioFilme> UsuarioFilme { get; set; }

    }
}
