namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity, TEntityId> //Repository Design Pattern
    {
       
        //CRUD- Create, Read, Update, Delete
     
        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null);
  

        //Func<TEntity,bool>predicateFunc=(Tentity entity)=> {return entity.Name=="";};
        //bool predicate(TEntity entity) 
        //{
        //    bool result = entity.Name == "";
        //    return result;
        //}
        //Func<TEntity, bool> predicateFunc =predicate;
        public TEntity? Get(Func<TEntity, bool> predicate);
        public TEntity Add(TEntity entity);
        public TEntity Update(TEntity entity);

        public TEntity Delete(TEntity entity, bool isSoftDelete = true);
    }
}