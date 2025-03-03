using System.Text;
using TesteTecnicoTarget.Models;
using TesteTecnicoTarget.Services;

namespace TesteTecnicoTarget;

public class ProvaTecnica
{
    private List<DiaDoMes> _diasDoMes;
    public ProvaTecnica(string path)
    {
        _iniciaListaDiaDoMes(path);
    }
    
    public int QuestaoUm(int indice, int k)
    {
        int soma = 0;

        while(k < indice)
        {
            k++;
            soma += k;
        }
        Console.WriteLine(soma);
        return soma;
    }

    public bool QuestaoDois(int numero)
    {
        List<int> fibonacci = GerarFibonacci(numero);

        if(fibonacci.Count == 0)
        {
            Console.WriteLine($"O número {numero} não está na sequência de fibonacci.");
            return false;
        }

        if(fibonacci.Contains(numero))
        {
            Console.WriteLine($"O número {numero} está na sequência de fibonacci.");
            return true;
        }
        else
        {
            Console.WriteLine($"O número {numero} não está na sequência de fibonacci.");
            return false;
        }
    }

    private List<int> GerarFibonacci(int numero)
    {
        List<int> fibonacci = new List<int>();

        if(numero < 0)
        {
            return fibonacci;
        }

        int primeiro = 0, segundo = 1;

        fibonacci.Add(primeiro);
        if(numero > 0)
        {
            fibonacci.Add(segundo);
        }

        while(segundo <= numero)
        {
            int proximo = primeiro + segundo;
            fibonacci.Add(proximo);
            primeiro = segundo;
            segundo = proximo;
        }

        return fibonacci;
    }
    
    private void _iniciaListaDiaDoMes(string path)
    {
        JsonFileReader<DiaDoMes> leitor = new();
        var diasDoMes = leitor.LeitorDeArquivo(path);
        _diasDoMes = diasDoMes;
    }
    
    public double QuestaoTresRetornaOMenorFaturamento()
    {
            
        var menorFaturamento = _diasDoMes
            .Where(d => d.Valor != 0)
            .Min(dia => dia.Valor);

        return menorFaturamento;
    }

    public double QuestaoTresRetornaOMaiorFaturamento()
    {
        var maiorFaturamento = _diasDoMes
            .Where(d => d.Valor != 0)
            .Max(dia => dia.Valor);

        return maiorFaturamento;
    }

    public int QuestaoTresQuantosDiasAMEdiaFoiUltrapassada()
    {
        var diasDoMes = this._diasDoMes;

        var media = diasDoMes
            .Where(d => d.Valor != 0)
            .Average(d => d.Valor);

        var diasQueOValorFoiMaiorQueAMedia = diasDoMes
            .Where(d => d.Valor != 0)
            .Count(d => d.Valor > media);

        return diasQueOValorFoiMaiorQueAMedia;
    }
    
    public void QuestaoQuatro(List<EstadoDetalhado> estados)
    {
        double faturmanetoTotal = estados
            .Sum(e => e.Valor);

        estados.ForEach(
            e => e.Representacao = Math.Round(e.Valor / faturmanetoTotal * 100, 2));
        
        estados.ForEach(Console.WriteLine);
    }

    public String QuestaoCinco(string palavra)
    {
        StringBuilder stringInvertida = new ();

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            stringInvertida.Append(palavra[i]);
        }
            
        Console.WriteLine($"{palavra} -> {stringInvertida.ToString()}");

        return stringInvertida.ToString();
    }
}