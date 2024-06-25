using AutoMapper;
using CompanyClaims.Data.Repositories.Interfaces;
using CompanyClaims.Models;
using NSubstitute;

namespace CompanyClaims.Service.UnitTests
{
    public class CompanyServiceTests
    {
        private CompanyService _sut;
        private ICompanyRepository _mockCompanyRepository;
        private IMapper _mockMapper;

        [SetUp]
        public void Setup()
        {
            _mockCompanyRepository = Substitute.For<ICompanyRepository>();
            _mockMapper = Substitute.For<IMapper>();
            _sut = new CompanyService(_mockCompanyRepository, _mockMapper);
        }

        [Test]
        public async Task GetCompanyByName_ReturnsCompany_MapsToModel()
        {
            //Arrange
            var company = new Data.Entities.Company
            {
                Id = 1,
                Name = "TestCompany",
                Postcode = "TST 1XP"
            };

            _mockCompanyRepository.GetCompanyByName(company.Name).Returns(company);
            _mockMapper.Map<Company>(company).Returns(new Company
            {
                Id = company.Id,
                Name = company.Name,
                Postcode = company.Postcode
            });

            //Act
            var response = await _sut.GetCompanyByName(company.Name);

            //Assert
            Assert.That(response.Id, Is.EqualTo(company.Id));
            Assert.That(response.Name, Is.EqualTo(company.Name));
            Assert.That(response.Postcode, Is.EqualTo(company.Postcode));

            await _mockCompanyRepository.Received().GetCompanyByName(company.Name);
            _mockMapper.Received().Map<Company>(company);
        }
    }
}