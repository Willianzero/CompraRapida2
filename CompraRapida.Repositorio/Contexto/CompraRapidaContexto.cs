using CompraRapida.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using CompraRapida.Dominio.ObjetoValor;
using CompraRapida.Repositorio.Config;

namespace CompraRapida.Repositorio.Contexto
{
    public class CompraRapidaContexto : DbContext
    {
      
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FomaPagamento> FormaPagamento{ get; set; }

        public CompraRapidaContexto(DbContextOptions options) : base(options)
        {
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfigurantion());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
