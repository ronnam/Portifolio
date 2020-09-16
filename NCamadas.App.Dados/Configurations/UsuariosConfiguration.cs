using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Pessoa;

namespace NCamadas.App.Dados.Configurations
{
    internal class UsuariosConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .Property(u => u.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(25);
            builder
                .Property(u => u.NomeDoMeio)
                .HasColumnType("varchar")
                .HasMaxLength(25);
            builder
                .Property(u => u.UltimoNome)
                .HasColumnType("varchar")
                .HasMaxLength(35);
            builder
                .Property(u => u.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
}
