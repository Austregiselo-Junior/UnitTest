using Moq;
using UnitTestwithXUnit.Features.Calculadora.Services;

namespace UnitTest.Test.Features.Calculadora.Services
{
    public class CalculadoraServiceTests : IDisposable
    {
        private MockRepository _mockRepository;

        public CalculadoraServiceTests()
        {
            this._mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private CalculadoraService CreateService()
        {
            return new CalculadoraService();
        }

        [Fact]
        public void Dividir_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            double n1 = 8;
            double n2 = 4;

            // Act
            var result = service.Dividir(
                n1,
                n2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiplicar_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            double n1 = 2;
            double n2 = 4;

            // Act
            var result = service.Multiplicar(
                n1,
                n2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Somar_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            double n1 = 2;
            double n2 = 4;

            // Act
            var result = service.Somar(
                n1,
                n2);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Subtrair_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            double n1 = 6;
            double n2 = 4;

            // Act
            var result = service.Subtrair(
                n1,
                n2);

            // Assert
            Assert.Equal(2, result);
        }

        public void Dispose()
        {
            _mockRepository.VerifyAll();
        }
    }
}