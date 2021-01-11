using Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Test.Domain
{
    [TestClass]
    public class InformacoesGitTest
    {
        private JurosService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new JurosService();
        }

        [TestMethod]
        public async Task TestShowMeTheCode()
        {
            // Arrange
            var nome = "Vinícius Batista Barreira";
            var url = "https://github.com/Viniciustes/DesafioTecnico.git";

            // Act
            var result = await _service.ShowMeTheCode();

            // Assert
            Assert.IsTrue(result.Nome.Equals(nome));
            Assert.IsTrue(result.Url.Equals(url));
        }
    }
}
