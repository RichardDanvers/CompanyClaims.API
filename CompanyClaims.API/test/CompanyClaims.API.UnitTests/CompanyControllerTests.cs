using CompanyClaims.API.Controllers;
using CompanyClaims.Models;
using CompanyClaims.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace CompanyClaims.API.UnitTests
{
    public class CompanyControllerTests
    {
        private CompanyController _sut;
        private ICompanyService _mockCompanyService;

        [SetUp]
        public void Setup()
        {
            _mockCompanyService = Substitute.For<ICompanyService>();
            _sut = new CompanyController(_mockCompanyService);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]
        public async Task Get_NullOrWhitespace_CompanyName_ReturnsBadRequest(string companyName)
        {
            //Act
            var response = await _sut.Get(companyName);
            var result = response as BadRequestObjectResult;

            // Assert
            Assert.That(result.StatusCode, Is.EqualTo(400));
            Assert.That(result.Value, Is.EqualTo("Company name must be provided"));

            await _mockCompanyService.DidNotReceive().GetCompanyByName(Arg.Any<string>());
        }

        [Test]
        public async Task Get_CompanyNull_ReturnsNotFound()
        {
            //Arrange
            var companyName = "TestCompany";

            //Act
            var response = await _sut.Get(companyName);
            var result = response as NotFoundObjectResult;

            // Assert
            Assert.That(result.StatusCode, Is.EqualTo(404));
            Assert.That(result.Value, Is.EqualTo($"Could not find company with name: {companyName}"));

            await _mockCompanyService.Received().GetCompanyByName(companyName);
        }

        [Test]
        public async Task Get_CompanyNull_ReturnsOk_WithCompany()
        {
            //Arrange
            var company = new Company
            {
                Name = "TestCompany",
                Active = true,
                Address1 = "Test address 1"
            };

            _mockCompanyService.GetCompanyByName(company.Name).Returns(company);

            //Act
            var response = await _sut.Get(company.Name);
            var result = response as OkObjectResult;

            // Assert
            Assert.That(result.StatusCode, Is.EqualTo(200));
            Assert.That(result.Value, Is.SameAs(company));

            await _mockCompanyService.Received().GetCompanyByName(company.Name);
        }
    }
}
