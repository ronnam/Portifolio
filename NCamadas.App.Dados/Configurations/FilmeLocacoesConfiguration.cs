using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Locadora;

namespace NCamadas.App.Dados.Configurations
{
    internal class FilmeLocacoesConfiguration : IEntityTypeConfiguration<FilmeLocacao>
    {
        public void Configure(EntityTypeBuilder<FilmeLocacao> builder)
        {
            builder
                .ToTable("FilmeLocacoes");
            builder
                .HasKey(fl => new { fl.FilmeId, fl.LocacaoId});
        }
    }
}
