using CompraRapida.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CompraRapida.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(30);
            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(30);
            builder
                .Property(p => p.Preco)
                .IsRequired()
                .HasMaxLength(8);
            builder
                .Property(p => p.NomeArquivo)
                .HasMaxLength(50);
                

        }
    }
}
