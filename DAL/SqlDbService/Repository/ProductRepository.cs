using DAL.Entity;
using DAL.SqlDbService.SqlDbContext;

namespace DAL.SqlDbService.Repository
{
    public class ProductRepository : BaseRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

        public void MyCustomUpdateFunction()
        {
            throw new NotImplementedException();
        }
    }
}
