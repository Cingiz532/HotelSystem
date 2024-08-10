using DataAccess.Abstract;
using Entitties.Abstract;
using Entitties.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class,IEntity  ,new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using TContext context = new TContext();
            var added = context.Entry(entity);
            added.State = EntityState.Added;
            context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            using(var  context = new TContext())
            {
                var deleted = context.Entry(entity);
                deleted.State=EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using TContext context = new TContext();
            var updated = context.Entry(entity);
            updated.State = EntityState.Modified;
            context.SaveChanges();
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext context = new TContext();
            if (filter == null)
            {
                var result = context.Set<TEntity>().ToList();
                return result;
            }
            else
            {
                var result = context.Set<TEntity>().Where(filter).ToList(); 
                return result;
            } 
                
        }
        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }
}
