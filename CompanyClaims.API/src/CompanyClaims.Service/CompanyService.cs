using AutoMapper;
using CompanyClaims.Data.Repositories.Interfaces;
using CompanyClaims.Models;
using CompanyClaims.Service.Interfaces;

namespace CompanyClaims.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<Company> GetCompanyByName(string companyName)
        {
            var company = await _companyRepository.GetCompanyByName(companyName);

            return _mapper.Map<Company>(company);
        }
    }
}
