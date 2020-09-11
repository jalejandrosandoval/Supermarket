using APIRESTFul.Domain.Models;
using APIRESTFul.Extentions;
using APIRESTFul.Resources;
using AutoMapper;

namespace APIRESTFul.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Products, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
