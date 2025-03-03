using System.Text.Json;

namespace TesteTecnicoTarget.Services;

public class JsonFileReader<T>
{
    private string LerArquivoJsonETransformarEmString(string path)
    {
        string json = "";
            
        if(File.Exists(path))
        {
            json = File.ReadAllText(path);
        }
        else
        {
            throw new FileNotFoundException($"O arquivo {path} não foi encontrado.");
        }
            
        return json;
    }

    private List<T> TransformaStringJsonEmList(string json)
    {
        List<T> values = new();
        values = JsonSerializer.Deserialize<List<T>>(json);
        return values;
    }

    public List<T> LeitorDeArquivo(string path)
    {
        return TransformaStringJsonEmList(LerArquivoJsonETransformarEmString(path).Replace("d", "D").Replace("v", "V"));
    }
}