using CompraRapida.Dominio.ObjetoValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraRapida.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FomaPagamento>
    {
        public void Configure(EntityTypeBuilder<FomaPagamento> builder)
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
            builder
                .Property(f => f.EhBoleto)
                .HasColumnType("boolean");
            builder
                .Property(f => f.EhCartaoCredito)
                .HasColumnType("boolean");
            builder
                .Property(f => f.EhDeposito)
                .HasColumnType("boolean");
            builder
                .Property(f => f.EhNaoFoiDefinido)
                .HasColumnType("boolean");


        }
    }
}
