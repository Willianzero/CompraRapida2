using CompraRapida.Dominio.ObjetoValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraRapida.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);
            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(10);
            builder
                .Property(f => f.Descricao)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(30);
           
        }
    }
}
