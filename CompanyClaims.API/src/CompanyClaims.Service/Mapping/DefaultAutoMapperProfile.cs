using AutoMapper;
using CompanyClaims.Data.Entities;

namespace CompanyClaims.API.Configuration
{
    public class DefaultAutoMapperProfile : Profile
    {
        public DefaultAutoMapperProfile() {
            CreateMap<Models.Company, Company>()
                .ReverseMap();

            CreateMap<Models.Claim, Claim>()
                .ReverseMap();
        }
    }
}
