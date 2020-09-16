using NCamadas.App.Modelo.Pessoa;
using System;
using System.Collections.Generic;

namespace NCamadas.App.Modelo.Locadora
{
    public class Locacao
    {
        public int Id { get; internal set; }
        public DateTime Tempo { get; internal set; }
        public decimal Total { get; internal set; }
        public int Quantidade { get; internal set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public IList<FilmeLocacao> Filmes { get; set; }
    }
}
