using Core.DataAcess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, Tcontext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where Tcontext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
           using(Tcontext context = new Tcontext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
           using(Tcontext context = new Tcontext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
          using(Tcontext context = new Tcontext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? filter = null)
        {
           using(Tcontext context = new Tcontext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
