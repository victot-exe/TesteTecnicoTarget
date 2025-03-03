using TesteTecnicoTarget;

namespace TesteTecnicoTargetTest;

public class ProvaTecnicaFixture
{
    public ProvaTecnica Prova { get; }

    public ProvaTecnicaFixture()
    {
        const string path = @"C:\Users\viict\RiderProjects\TesteTecnicoTarget\TesteTecnicoTarget\Resources\dados.json";
        Prova = new ProvaTecnica(path);
    }
}