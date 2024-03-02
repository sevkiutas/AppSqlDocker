namespace DAL.SqlDbService.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate = null);
        TEntity GetById(int id);
        Task Add(TEntity model);
        Task Update(TEntity model);
        void Delete(int id);
    }
}
