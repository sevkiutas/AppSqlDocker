using Contract.Dto;

namespace Bussiness.ProductManager
{
	public interface IProductManager
	{
		void Add(ProductDto obj);
		void Update(ProductDto obj);
		void Delete(int id);
		ProductDto GetById(int id);
		IEnumerable<ProductDto> GetAll();
	}
}
