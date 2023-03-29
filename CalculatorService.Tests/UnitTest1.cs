namespace CalculatorService.Tests;

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }

    [Fact]
    public void TestarSomaPositiva()
    {
        int a = 1;
        int b = 1;
        var resultado = calc.Soma(a, b);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestarSomaNegativa()
    {
        int a = -2;
        int b = -2;
        var resultado = calc.Soma(a, b);
        Assert.Equal(-4, resultado);
    }

    [Fact]
    public void TestarSomaPositvaNegativa()
    {
        int a = 1;
        int b = -1;
        var resultado = calc.Soma(a, b);
        Assert.Equal(0, resultado);
    }

    /*[Fact]
    public void TestarSomaComNaN()
    {
        int a = 2;
        double b = double.NaN;
        double resultado = calc.Soma(a, b);
        Assert.True(double.IsNaN(resultado));
    }*/
}

public class SubtracaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSubtracaoPositiva()
    {
        int a = 3;
        int b = 1;
        var resultado = calc.Subtracao(a, b);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestarSubtracaoPositivaNegativa()
    {
        int a = 10;
        int b = -1;
        var resultado = calc.Subtracao(a, b);
        Assert.Equal(11, resultado);
    }

    [Fact]
    public void TestarSubtracaoNegativa()
    {
        int a = -1;
        int b = -1;
        var resultado = calc.Subtracao(a, b);
        Assert.Equal(0, resultado);
    }

    [Fact]
    public void TestarSubtracaoComMenorNumero()
    {
        int a = int.MinValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Subtracao(a, b));
    }

    /*[Fact]
    public void TestarSomaComNaN()
    {
        int a = 2;
        double b = double.NaN;
        double resultado = calc.Subtracao(a, b);
        Assert.True(double.IsNaN(resultado));
    }*/

}

public class MultiplicacaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarMultiplicacaoPositiva()
    {
        int a = 2;
        int b = 2;
        var resultado = calc.Multiplicacao(a, b);
        Assert.Equal(4, resultado);
    }

    [Fact]
    public void TestarMultiplicacaoPositivaNegativa()
    {
        int a = 2;
        int b = -2;
        var resultado = calc.Multiplicacao(a, b);
        Assert.Equal(-4, resultado);
    }

    [Fact]
    public void TestarMultiplicacaoNegativa()
    {
        int a = -2;
        int b = -2;
        var resultado = calc.Multiplicacao(a, b);
        Assert.Equal(4, resultado);
    }

    /*[Fact]
    public void TestarMultiplicacaoComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Multiplicacao(a, b));
    }*/

    /*[Fact]
    public void TestarMultiplicacaoComNaN()
    {
        int a = 2;
        double b = double.NaN;
        double resultado = calc.Multiplicacao(a, b);
        Assert.True(double.IsNaN(resultado));
    }*/
}

public class DivisaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }

    [Fact]
    public void TestarDivisaoPositiva()
    {
        int a = 2;
        int b = 2;
        var resultado = calc.Divisao(a, b);
        Assert.Equal(1, resultado);
    }

    [Fact]
    public void TestarDivisaoPositivaNegativa()
    {
        int a = 10;
        int b = -2;
        var resultado = calc.Divisao(a, b);
        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void TestarDivisaoNegativa()
    {
        int a = -2;
        int b = -2;
        var resultado = calc.Divisao(a, b);
        Assert.Equal(1, resultado);
    }

    [Fact]
    public void TestarDivisaoZero()
    {
        double a = 10;
        double b = 0;
        var resultado = calc.Divisao(a, b);
        Assert.Equal(double.PositiveInfinity, resultado);
    }

}

public class MediaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarMediaPositiva()
    {
        int a = 2;
        int b = 2;
        var resultado = calc.Media(a, b);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestarMediaPositivaNegativa()
    {
        int a = 10;
        int b = -6;
        var resultado = calc.Media(a, b);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestarMediaNegativa()
    {
        int a = -2;
        int b = -2;
        var resultado = calc.Media(a, b);
        Assert.Equal(-2, resultado);
    }
}

public class MedianaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarMediana()
    {
        int a = 9;
        int b = 11;
        var resultado = calc.Mediana(a, b);
        Assert.Equal(10, resultado);
    }


}
