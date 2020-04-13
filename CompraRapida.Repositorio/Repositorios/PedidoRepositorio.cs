using CompraRapida.Dominio.Contratos;
using CompraRapida.Dominio.Entidades;
using CompraRapida.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(CompraRapidaContexto compraRapidaContexto) : base(compraRapidaContexto)
        {
        }
    }
}
