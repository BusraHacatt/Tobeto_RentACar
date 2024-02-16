using Core.Entities;

namespace Core.DataAccess.EntityFramework
{
//    public class EfEntityRepositoryBase<TEntity, TEntityId, TContext> : IEntityRepository<TEntity, TEntityId>
//        where TEntity : class, IEntity<TEntityId>, new()
//        where TContext : class TContext 
//    {
//        protected readonly HashSet<TEntity> Entities = new();
//        public TEntity Add(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                entity.CreatedAt = DateTime.UtcNow;
//                var addedEntity = context.Entry(entity);
//                addedEntity.State = EntityState.Added;
//                context.SaveChanges();
//                return entity;
//            }
//        }

//        public TEntity Delete(TEntity entity, bool isSoftDelete = true)
//        {
//            using (TContext context = new TContext())
//            {
//                entity.DeletedAt = DateTime.UtcNow;
//                if (!isSoftDelete)
//                {
//                    var deletedEntity = context.Entry(entity);
//                    deletedEntity.State = EntityState.Deleted;
//                    context.SaveChanges();
//                }
//                //_context.Entry(entity).State = EntityState.Modified;

//                return entity;
//            }
//        }

//        public TEntity? Get(Func<TEntity, bool> predicate)
//        {

//            using (TContext context = new TContext())
//            {
//                return context.Set<TEntity>().SingleOrDefault(predicate);
//            }


//        }

//        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null)
//        {
//            using (TContext context = new TContext())
//            {
//                IQueryable<TEntity> query = context.Set<TEntity>();
//                if (predicate != null)
//                {
//                    query = query.Where(predicate).AsQueryable();
//                }

//                return query.ToList();
//            }
//        }

//        public TEntity Update(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                entity.UpdatedAt = DateTime.UtcNow;
//                var updatedEntity = context.Entry(entity);
//                updatedEntity.State = EntityState.Modified;
//                context.SaveChanges();
//                return entity;
//            }
//        }
//    }
}