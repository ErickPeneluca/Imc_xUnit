using System.Security;
using NutriVitta;
using Xunit;

namespace CalcularXUnit;

public class UnitTest1
{
    [Fact]
    public void CalcularImc()
    {
        //arrange

        double peso = 80;
        double altura = 1.75;
        double resultadoEsperado = peso / (altura * altura);
        //act

        var resultado = Calcular.CalcularImc(peso, altura);
        //asssert

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(60, 1.70, 60 / (1.70 * 1.70))]
    [InlineData(70, 1.72, 70 / (1.72 * 1.72))]
    [InlineData(80, 1.75, 80 / (1.75 * 1.75))]
    public void CalcularImcMultipla(double peso, double altura, double resultado)
    {
        double resultadoEsperado = Calcular.CalcularImc(peso, altura);

        Assert.Equal(resultado, resultadoEsperado);
    }
}