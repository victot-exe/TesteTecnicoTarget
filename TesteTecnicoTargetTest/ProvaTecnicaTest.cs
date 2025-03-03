using TesteTecnicoTarget;
using TesteTecnicoTarget.Models;

namespace TesteTecnicoTargetTest;

public class ProvaTecnicaTest : IClassFixture<ProvaTecnicaFixture>
{
    private ProvaTecnica _prova;

    public ProvaTecnicaTest(ProvaTecnicaFixture  fixture)
    {
        _prova = fixture.Prova;
    }

    [Fact]
    [Trait("Descrição", "ProvaTecnica: Questão Um")]
    public void QuestaoUmTest()
    {
        var result = _prova.QuestaoUm(13, 0);
        
        Assert.Equal(91, result);
    }

    [Fact]
    [Trait("Descrição ", "ProvaTecnica: Questão Dois")]
    public void QuestaoDoisTest()
    {
        var result = _prova.QuestaoDois(0);
        Assert.True(result);
        result = _prova.QuestaoDois(5);
        Assert.True(result);
        
        result = _prova.QuestaoDois(258);
        Assert.False(result);
        
        result = _prova.QuestaoDois(2584);
        Assert.True(result);
    }

    [Fact]
    [Trait("Descrição ", "ProvaTecnica: Questão Tres")]
    public void QuestaoTresTest()
    {
        var menorFaturamento = _prova.QuestaoTresRetornaOMenorFaturamento();
        var maiorFaturamento =  _prova.QuestaoTresRetornaOMaiorFaturamento();
        var diasQueOFaturamentoUltrapassouAMedia = _prova.QuestaoTresQuantosDiasAMEdiaFoiUltrapassada();
        
        Assert.Equal(373.7838, menorFaturamento);
        Assert.Equal(48924.2448, maiorFaturamento);
        Assert.Equal(10, diasQueOFaturamentoUltrapassouAMedia);
    }

    [Fact]
    [Trait("Descrição ", "ProvaTecnica: Questão Quatro")]
    public void QuestaoQuatroDeveCalcularARepresentacaoCorretamente()
    {
        var estados = new List<EstadoDetalhado>
        {
            new EstadoDetalhado ("SP", 67836.43),
            new EstadoDetalhado ("RJ", 36678.66),
            new EstadoDetalhado ("MG", 29229.88),
            new EstadoDetalhado ("ES", 27165.48),
            new EstadoDetalhado ("Outros", 19849.53)
        };
        
        _prova.QuestaoQuatro(estados);
        
        Assert.Equal(37.53, estados[0].Representacao, 2);
        Assert.Equal(20.29, estados[1].Representacao, 2);
        Assert.Equal(16.17, estados[2].Representacao, 2);
        Assert.Equal(15.03, estados[3].Representacao, 2);
        Assert.Equal(10.98, estados[4].Representacao, 2);
    }

    [Fact]
    [Trait("Descrição ", "ProvaTecnica: Questão Cinco")]
    public void QuestaoCincoTest()
    {
        var result1 = _prova.QuestaoCinco("String");
        var result2 = _prova.QuestaoCinco("Victor");
        var result3 = _prova.QuestaoCinco("boa tarde!");
        
        Assert.Equal("gnirtS", result1);
        Assert.Equal("rotciV", result2);
        Assert.Equal("!edrat aob", result3);
    }
}