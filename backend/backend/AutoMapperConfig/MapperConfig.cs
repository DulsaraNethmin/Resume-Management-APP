using AutoMapper;
using backend.Dtos;
using backend.Enties;

namespace backend.AutoMapperConfig
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CompanyCreateDto, Company>();
        }
    }
}
