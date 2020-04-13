using CompraRapida.Dominio.Contratos;
using CompraRapida.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompraRapida.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly CompraRapidaContexto CompraRapidaContexto;
        public BaseRepositorio(CompraRapidaContexto compraRapidaContexto)
        {
            CompraRapidaContexto = compraRapidaContexto;
          
        }
        public void Adicionar(TEntity entity)
        {
            CompraRapidaContexto.Set<TEntity>().Add(entity);
            CompraRapidaContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            CompraRapidaContexto.Set<TEntity>().Update(entity);
            CompraRapidaContexto.SaveChanges();
        }
           
        public TEntity ObterPorId(int id)
        {
            return CompraRapidaContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return CompraRapidaContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            CompraRapidaContexto.Remove(entity);
            CompraRapidaContexto.SaveChanges();
        }
        public void Dispose()
        {
            CompraRapidaContexto.Dispose();
        }
    }
}

