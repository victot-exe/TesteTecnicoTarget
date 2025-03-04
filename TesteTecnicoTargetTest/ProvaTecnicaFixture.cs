using TesteTecnicoTarget;

namespace TesteTecnicoTargetTest;

public class ProvaTecnicaFixture
{
    public ProvaTecnica Prova { get; }

    public ProvaTecnicaFixture()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "dados.json");
        Prova = new ProvaTecnica(filePath);
    }
}