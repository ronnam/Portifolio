using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Pessoa;

namespace NCamadas.App.Dados.Configurations
{
    internal class EnderecosConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
                .ToTable("Enderecos");
            builder
                .Property<int>("ClienteId");
            builder
                .HasKey("ClienteId");
            builder
                .Property(e => e.Logradouro)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            builder
                .Property(e => e.Numero)
                .HasColumnType("INTEGER");
            builder
                .Property(e => e.Complemento)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            builder
                .Property(e => e.Bairro)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            builder
                .Property(e => e.Cidade)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            builder
                .Property(e => e.Estado)
                .HasColumnType("VARCHAR")
                .HasMaxLength(2);
        }
    }
}
