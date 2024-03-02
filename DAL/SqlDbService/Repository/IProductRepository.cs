using DAL.Entity;

namespace DAL.SqlDbService.Repository
{
    public interface IProductRepository : IBaseRepository<ProductEntity>
    {
        void MyCustomUpdateFunction();

        //BaseRepository haricinde, salt Product ile ilgili ekstra db işlemleri yapmak istediğimizde ProducRepository i kullanabiliriz.
    }
}
