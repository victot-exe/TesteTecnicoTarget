namespace TesteTecnicoTarget.Models;

public class DiaDoMes
{
    public int Dia{ get; set; }
    public double Valor{ get; set; }

    public override string ToString()
    {
        return $"Dia: {Dia} -> valor: R$ {Valor}";
    }
}