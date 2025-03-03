using TesteTecnicoTarget;

namespace TesteTecnicoTargetTest;

public class ProvaTecnicaFixture
{
    public ProvaTecnica Prova { get; }

    public ProvaTecnicaFixture()
    {
        const string path = @"Seu/AbsolutePath/Aqui";
        Prova = new ProvaTecnica(path);
    }
}
