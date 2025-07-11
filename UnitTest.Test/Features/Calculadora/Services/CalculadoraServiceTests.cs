using Moq;
using UnitTestwithXUnit;
using UnitTestwithXUnit.Features.Calculadora.Contracts;

namespace UnitTest.Test.Features.Calculadora.Services
{
    public class CalculadoraServiceTests : IDisposable
    {
        private readonly MockRepository _mockRepository;
        private readonly Mock<ICalculadora> _mockICalculadora;

        public CalculadoraServiceTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockICalculadora = _mockRepository.Create<ICalculadora>();
        }

        private User CreateUser()
        {
            return new User(_mockICalculadora.Object);
        }

        [Fact]
        public void Calculadora_Dividir_DivisaoDosNumeros()
        {
            // Arrange
            var service = CreateUser();
            double n1 = 8;
            double n2 = 4;
            _mockICalculadora.Setup(x => x.Dividir(n1, n2)).Returns(2); // Mocka o serviço para retornar 2

            // Act
            var result = service.Divisao(n1, n2); // Chama o método a ser testado através do mock


            // Assert
            Assert.Equal(2, result); // Verifica se o resultado é igual a 2
        }

        [Fact]
        public void Calculadora_Multiplicar_MultiplicacaoDosNumeros()
        {
            // Arrange
            var service = CreateUser();
            double n1 = 2;
            double n2 = 4;
            _mockICalculadora.Setup(x => x.Multiplicar(n1, n2)).Returns(8);

            // Act
            var result = service.Multiplicacao(
                n1,
                n2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Calculadora_Somar_SomaDosNumeros()
        {
            // Arrange
            var service = this.CreateUser();
            double n1 = 2;
            double n2 = 4;
            _mockICalculadora.Setup(x => x.Somar(n1, n2)).Returns(6);

            // Act
            var result = service.Somatorio(
                n1,
                n2);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Calculadora_Subtrair_SubitracaoDosNumeros()
        {
            // Arrange
            var service = this.CreateUser();
            double n1 = 6;
            double n2 = 4;
            _mockICalculadora.Setup(x => x.Subtrair(n1, n2)).Returns(2);

            // Act
            var result = service.Subtracao(
                n1,
                n2);

            // Assert
            Assert.Equal(2, result);
        }

        #region Dispose Methods
        protected virtual void Dispose(bool disposing)
        {
            _mockRepository.VerifyAll();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}