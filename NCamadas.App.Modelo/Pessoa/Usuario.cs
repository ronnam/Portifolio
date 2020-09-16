using NCamadas.App.Modelo.Locadora;
using System.Collections;
using System.Collections.Generic;

namespace NCamadas.App.Modelo.Pessoa
{
    public class Usuario
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string NomeDoMeio { get; internal set; }
        public string Email { get; internal set; }
        public string UltimoNome { get; internal set; }
        public Cliente Cliente { get; set; }

        public IList<UsuarioFilme> Filmes { get; set; }
    }
}
