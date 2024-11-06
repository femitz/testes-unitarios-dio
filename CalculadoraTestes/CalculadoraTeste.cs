using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTeste
{
    private CalculadoraImp _calc;

    public CalculadoraTeste()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void SomaDeveDar14()
    {
        // Arrage
        int x = 10;
        int y = 4;

        // Act
        int soma = _calc.Somar(x, y);

        // Assert
        Assert.Equal(14, soma);
    }

    [Fact]
    public void SomaDeveDar20()
    {
        // Arrage
        int x = 10;
        int y = 10;

        // Act
        int soma = _calc.Somar(x, y);

        // Assert
        Assert.Equal(20, soma);
    }

    [Fact]
    public void EhParDeveSerTrue()
    {
        // Arrage
        int num = 20;

        // Act
        bool resultado = _calc.EhPar(num);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void EhParDeveSerFalse()
    {
        // Arrage
        int num = 3;

        // Act
        bool resultado = _calc.EhPar(num);

        // Assert
        Assert.False(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act Assert

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}