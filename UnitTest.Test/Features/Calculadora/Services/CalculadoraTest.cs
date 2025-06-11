using UnitTestwithXUnit.Features.Calculadora.Services;

namespace UnitTest.Test.Features.Calculadora.Services
{
    public class CalculadoraTest
    {
        [Fact]
        public void Verificar_Soma_Retorna_Double()
        {
            //Arrage
            double n1 = 10;
            double n2 = 15;
            CalculadoraService service = new CalculadoraService();

            //Act
            double result = service.Somar(n1, n2);

            //Assert
            Assert.Equal(25, result);
        }
    }
}