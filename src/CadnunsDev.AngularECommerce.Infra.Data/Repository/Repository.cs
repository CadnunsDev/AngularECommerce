using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CadnunsDev.AngularECommerce.Domain.Interfaces.Repository;
using CadnunsDev.AngularECommerce.Infra.Data.ORM.Context;

namespace CadnunsDev.AngularECommerce.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ECommerceDbContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new ECommerceDbContext();
            DbSet = Db.Set<TEntity>();
        } 
       

        public TEntity Adicionar(TEntity entity)
        {
            var obj = DbSet.Add(entity);
            SaveChanges();
            return obj;
        }

        public TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            //para habilitar
            //int t = 10, int s = 0;
            //var paginaAtual = 1;
            //var itensPagina = 10;
            //return DbSet.Skip((paginaAtual - 1) * itensPagina)
            //       .Take(itensPagina).ToList();
            //return DbSet.Take(t).Skip(s).ToList();
            return DbSet.ToList();
        }

        public TEntity Atualizar(TEntity entity)
        {
            var entry = Db.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;
            SaveChanges();
            return entity;
        }

        public void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
            SaveChanges();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
