using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Pessoa;

namespace NCamadas.App.Dados.Configurations
{
    internal class TelefonesConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder
                .ToTable("Telefones");
            builder
                .Property<int>("ClienteId");
            builder
                .HasKey("ClienteId");
            builder
                .Property(t => t.Celular)
                .HasColumnType("VARCHAR")
                .HasMaxLength(11);
            builder
                .Property(t => t.Residencial)
                .HasColumnType("VARCHAR")
                .HasMaxLength(10);
        }
    }
}
