using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Locadora;

namespace NCamadas.App.Dados.Configurations
{
    internal class FilmesConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
                .Property(f => f.Titulo)
                .HasColumnType("VARCHAR")
                .HasMaxLength(10);
            builder
                .Property(f => f.Classificacao)
                .HasColumnType("INTEGER");
            builder
                .Property(f => f.Genero)
                .HasColumnType("INTEGER");
            builder
                .Property(f => f.Ano)
                .HasColumnType("DATE");
            builder
                .Property(f => f.Preco)
                .HasColumnType("DECIMAL(5,2)");
        }
    }
}
