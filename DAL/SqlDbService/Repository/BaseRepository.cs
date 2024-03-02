using DAL.SqlDbService.SqlDbContext;

namespace DAL.SqlDbService.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }
        public async Task Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }
        public async Task Update(TEntity obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var obj = _context.Set<TEntity>().Find(id);
            if (obj != null)
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
        }
        public IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate = null)
        {
            if (predicate == null)
            {
                return _context.Set<TEntity>().ToList();
            }
            else
            {
                return _context.Set<TEntity>().Where(predicate).ToList();
            }
        }
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
    }
}
