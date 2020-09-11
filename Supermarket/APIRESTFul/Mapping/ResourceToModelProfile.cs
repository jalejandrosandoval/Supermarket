using APIRESTFul.Domain.Models;
using APIRESTFul.Resources;
using AutoMapper;

namespace APIRESTFul.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }

    }
}
