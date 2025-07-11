using UnitTestwithXUnit.Features.Calculadora.Contracts;

namespace UnitTestwithXUnit
{
    internal class User
    {
        private readonly ICalculadora _calculadora;

        public User(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        public double Somatorio(double n1, double n2)
        {
            return _calculadora.Somar(n1, n2);
        }

        public double Subtracao(double n1, double n2)
        {
            return _calculadora.Subtrair(n1, n2);
        }

        public double Multiplicacao(double n1, double n2)
        {
            return _calculadora.Multiplicar(n1, n2);
        }

        public double Divisao(double n1, double n2)
        {
            return _calculadora.Dividir(n1, n2);
        }
    }
}
