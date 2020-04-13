using CompraRapida.Dominio.Entidades;
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
                .IsRequired();
            builder
                .Property(p => p.UsuarioId)
                .IsRequired();
            builder
                .Property(p => p.DataPrevisaoEntrega);
            builder
                .Property(p => p.Estado)
                .HasMaxLength(2)
                .IsRequired();
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(13);
            builder
                .Property(p => p.Cidade)
                .HasMaxLength(30);
            builder
                .Property(p => p.EnderecoCompleto)
                .HasMaxLength(100);
            builder
                .Property(p => p.NumeroEndereco)
                .HasMaxLength(10);
            builder.Property(p => p.FormaPagamentoId);
            builder.Property(p => p.FormaPagamento);
            builder.Property(p => p.ItemPedido);

        }
    }
}
