using CompraRapida.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraRapida.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.DataPedido)
                .HasColumnType ("DateTime")
                .IsRequired();
            builder
                .Property(p => p.UsuarioId)
                .IsRequired();
            builder
                .Property(p => p.DatàPrevisaoEntrega)
                .HasColumnType("DateTime");
            builder
                .Property(p => p.Estado)
                .HasMaxLength(2)
                .IsRequired()
                .HasColumnType("char(2)");
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(13)
                .HasColumnType("vachar");
            builder
                .Property(p => p.Cidade)
                .HasMaxLength(30)
                .HasColumnType("varchar");
            builder
                .Property(p => p.EnderecoCompleto)
                .HasMaxLength(100)
                .HasColumnType("varchar");
            builder
                .Property(p => p.NumeroEndereco)
                .HasMaxLength(10)
                .HasColumnType("char(10)");
            builder.Property(p => p.FormaPagamentoId);
            builder.Property(p => p.FomaPagamento);
            builder.Property(p => p.ItemPedido);

        }
    }
}
