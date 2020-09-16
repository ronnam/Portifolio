using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Locadora;

namespace NCamadas.App.Dados.Configurations
{
    internal class UsuarioFilmesConfiguration : IEntityTypeConfiguration<UsuarioFilme>
    {
        public void Configure(EntityTypeBuilder<UsuarioFilme> builder)
        {
            builder
                .ToTable("UsuarioFilmes");
            builder
                .HasKey(uf => new { uf.UsuarioId, uf.FilmeId });
        }
    }
}
