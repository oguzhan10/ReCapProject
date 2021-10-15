using Core1.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core1.DataAccess.EntityFramework
{
    public class EfEntitiyRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity car)
        {
            using (TContext carsDB = new TContext())
            {
                var addedEntity = carsDB.Entry(car);
                addedEntity.State = EntityState.Added;
                carsDB.SaveChanges();
            }

        }

        public void Delete(TEntity car)
        {
            using (TContext carsDB = new TContext())
            {
                var deletedEntity = carsDB.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                carsDB.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext carsDB = new TContext())
            {
                return carsDB.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext carsDB = new TContext())
            {
                return filter == null
                    ? carsDB.Set<TEntity>().ToList()
                    : carsDB.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity car)
        {
            using (TContext carsDB = new TContext())
            {
                var updatedEntity = carsDB.Entry(car);
                updatedEntity.State = EntityState.Modified;
                carsDB.SaveChanges();
            }
        }
    }
}
