using Microsoft.EntityFrameworkCore;
using NCamadas.App.Dados.Configurations;
using NCamadas.App.Modelo.Locadora;
using NCamadas.App.Modelo.Pessoa;

namespace NCamadas.App.Dados.Context
{
    public class LocadoraContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Filme> Filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (
                "Server=(localdb)\\mssqllocaldb;Database=NCamadasDB;Trusted_Connection=true;"
                , x => x.MigrationsAssembly("NCamadas.App.Dados")
                );

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuariosConfiguration());
            modelBuilder.ApplyConfiguration(new ClientesConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecosConfiguration());
            modelBuilder.ApplyConfiguration(new TelefonesConfiguration());
            modelBuilder.ApplyConfiguration(new PagamentosConfiguration());
            modelBuilder.ApplyConfiguration(new LocacoesConfiguration());
            modelBuilder.ApplyConfiguration(new FilmesConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeLocacoesConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioFilmesConfiguration());
            
        }

    }

}
