namespace TesteTecnicoTarget.Models;

public class EstadoDetalhado
{
    private string Estado { get;}
    public double Valor { get; }
    public double Representacao { get; set; }

    public EstadoDetalhado(string estado, double valor)
    {
        this.Estado = estado;
        this.Valor = valor;
    }

    public override string ToString()
    {
        return $"O estado {Estado} teve o faturamento de R$ {Valor} que representa {Representacao:F2}% do faturamento total.";
    }
}