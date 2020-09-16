using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Locadora;

namespace NCamadas.App.Dados.Configurations
{
    internal class LocacoesConfiguration : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder
                .Property(l => l.Tempo)
                .HasColumnType("DATE");
            builder
                .Property(l => l.Total)
                .HasColumnType("DECIMAL");
            builder
                .Property(l => l.Quantidade)
                .HasColumnType("INTEGER");
        }
    }
}
