using UnitTestwithXUnit.Features.Calculadora.Contracts;

namespace UnitTestwithXUnit.Features.Calculadora.Services
{
    public class CalculadoraService : ICalculadora
    {
        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}