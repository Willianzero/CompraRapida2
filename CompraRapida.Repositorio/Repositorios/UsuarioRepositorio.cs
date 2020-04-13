using CompraRapida.Dominio.Contratos;
using CompraRapida.Dominio.Entidades;
using CompraRapida.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio

    {
        public UsuarioRepositorio(CompraRapidaContexto compraRapidaContexto) : base(compraRapidaContexto)
        {
        }
    }
}
