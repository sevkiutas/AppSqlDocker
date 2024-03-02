using AutoMapper;
using Contract.Dto;
using DAL.Entity;
using DAL.SqlDbService.Repository;

namespace Bussiness.ProductManager
{
    public class ProductManager : IProductManager
	{
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;
		public ProductManager(IProductRepository productRepository, IMapper mapper)
		{
			_mapper = mapper;
            _productRepository = productRepository;
		}

		public async void Add(ProductDto obj)
		{
			await _productRepository.Add(_mapper.Map<ProductDto, ProductEntity>(obj));
		}
		public async void Update(ProductDto obj)
		{
			await _productRepository.Update(_mapper.Map<ProductDto, ProductEntity>(obj));
		}
		public void Delete(int id)
		{
            _productRepository.Delete(id);
		}

		public IEnumerable<ProductDto> GetAll()
		{
			return _mapper.Map<IEnumerable<ProductEntity>, IEnumerable<ProductDto>>(_productRepository.GetAll());
		}

		public ProductDto GetById(int id)
		{
			return _mapper.Map<ProductEntity, ProductDto>(_productRepository.GetById(id));
		}
	}
}
