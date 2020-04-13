using CompraRapida.Dominio.Contratos;
using CompraRapida.Dominio.Entidades;
using CompraRapida.Repositorio.Contexto;

namespace CompraRapida.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(CompraRapidaContexto compraRapidaContexto) : base(compraRapidaContexto)
        {

        }
    }
}
