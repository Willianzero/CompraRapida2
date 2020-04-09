using CompraRapida.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace CompraRapida.Repositorio.Config
{
    public class ItemPedidoConfigurantion : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.ProdutoId);
            builder
                .Property(i => i.Quantidade)
                .HasMaxLength(20)
                .HasColumnType("decimal");

        }
    }
}
