using Calculadora.Services;

namespace CalculadoraTestes;

public class ValidacoesStringTeste
{   
    private ValidacoesString _validacoes;
    public ValidacoesStringTeste()
    {
        _validacoes = new ValidacoesString();
    }

    [Fact]
    public void ContagemDeCaracteresDeveSer5() 
    {
        // Arrange 
        string text = "texto";

        // Act
        int caracteres = _validacoes.ContarCaracteres(text);

        // Assert 
        Assert.Equal(5, caracteres);
    }
}