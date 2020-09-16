using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCamadas.App.Modelo.Pessoa;

namespace NCamadas.App.Dados.Configurations
{
    internal class ClientesConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .Property(c => c.CPF)
                .HasColumnType("VARCHAR")
                .HasMaxLength(11);
            builder
                .Property(c => c.Nascimento)
                .HasColumnType("DATE");
            builder
                .Property<int>("UsuarioId");
        }
    }
}
