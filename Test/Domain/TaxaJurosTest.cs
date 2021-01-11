using Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Test.Domain
{
    [TestClass]
    public class TaxaJurosTest
    {
        private JurosService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new JurosService();
        }

        [TestMethod]
        public async Task TestCalcularJuros()
        {
            // Arrange
            var valorInicial = 100.00m;
            var meses = 5;
            var resultado = "105,10";

            // Act
            var result = await _service.CalcularJuros(valorInicial, meses);

            // Assert
            Assert.IsTrue(result.Taxa.Equals(resultado));
        }
    }
}
