using NCamadas.App.Modelo.Pessoa;

namespace NCamadas.App.Modelo.Locadora
{
    public class UsuarioFilme
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario{ get; set; }
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
    }
}
