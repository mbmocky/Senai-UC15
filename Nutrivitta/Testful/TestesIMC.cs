using System;
using IMC;
using Xunit;

public class TestesIMC
{
    [Theory]
    [InlineData(72, 1.70, 24.91)]
    [InlineData(50, 1.10, 41.32)]
    [InlineData(74, 1.54, 32.03)]
    [InlineData(100, 1.71, 32.20)]
    public void TestarCalculo(double peso, double altura, double imc)
    {
        var resultado = Calculo.Calcular(peso, altura);

        Assert.Equal(imc, Math.Round(resultado, 2));
    }

    /// <summary>
    /// Testa a classificação do IMC de uma pessoa
    /// </summary>
    /// <param name="imc">IMC da pessoa</param>
    /// <param name="classificacao">Classificação do IMC conforme tabela da Abeso</param>
    [Theory]
    [InlineData(22.05, Classificacao.PesoNormal)]
    [InlineData(17.85, Classificacao.AbaixoDoPeso)]
    [InlineData(28.51, Classificacao.Sobrepeso)]
    [InlineData(20.34, Classificacao.ObesidadeGrauI)]
    public void TestarClassificacao(double imc, Classificacao classificacao)
    {        
        var resultado = Calculo.Classificar(imc);

        Assert.Equal(classificacao, resultado);
    }
}
