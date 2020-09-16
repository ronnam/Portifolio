using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Pessoa;

namespace NCamadas.App.Dados.Configurations
{
    class PagamentosConfiguration : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder
                .ToTable("Pagamentos");
            builder
                .Property<int>("ClienteId");
            builder
                .HasKey("ClienteId");
            builder
                .Property<int>("TipoDePagamento");
        }
    }
}
