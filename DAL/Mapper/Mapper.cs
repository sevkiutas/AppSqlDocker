using AutoMapper;
using Contract.Dto;
using DAL.Entity;

namespace DAL.Mapper
{
	public class Mapper : Profile
	{
		public Mapper()
		{
			CreateMap<ProductEntity, ProductDto>();
			CreateMap<ProductDto, ProductEntity>();
		}
	}
}
