# Teste Técnico - Target

Este repositório contém o código para um teste técnico realizado para a empresa TargetSistemas. O objetivo deste teste é resolver questões envolvendo manipulação de dados, cálculos e uso de programação orientada a objetos.

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado.
- [Visual Studio Code](https://code.visualstudio.com/) ou [Rider](https://www.jetbrains.com/rider/) (ou outro editor de sua preferência) para desenvolvimento.
- O arquivo `dados.json` deve ser localizado dentro da pasta `Resources/` para que os testes possam ser executados corretamente.

## Executando os Testes

1. Certifique-se de que o caminho do arquivo `dados.json` esteja corretamente configurado.

   O arquivo `dados.json` contém os dados necessários para a execução dos testes. O caminho deste arquivo é esperado na variável `path` no código. Para testar localmente, altere o caminho para o arquivo conforme o seu ambiente.

   **Importante:** Antes de executar os testes, altere o valor da variável `path` no arquivo `TesteTecnicoTargetTest\ProvaTecnicaFixture.cs` para o local onde o seu arquivo `dados.json` está armazenado em `TesteTecnicoTarget\Resources\dados.json`

   Exemplo de configuração do caminho para o arquivo `dados.json`:
~~~csharp
using TesteTecnicoTarget;

namespace TesteTecnicoTargetTest;

public class ProvaTecnicaFixture
{
    public ProvaTecnica Prova { get; }

    public ProvaTecnicaFixture()
    {
        const string path = @"Seu AbsolutePath Aqui";
        Prova = new ProvaTecnica(path);
    }
}
~~~
2. Execute os testes com o seguinte comando:
   ~~~bash
   dotnet test
   ~~~
# Questões
Questão 1 - Soma de números
Implementa um método que calcula a soma de números de 1 até um número informado.

Questão 2 - Fibonacci
Implementa um método que verifica se um número informado pertence ou não à sequência de Fibonacci.

Questão 3 - Faturamento Mensal
Implemente os seguintes cálculos de faturamento mensal:

* Menor faturamento ocorrido em um dia.  
* Maior faturamento ocorrido em um dia.  
* Número de dias no mês em que o faturamento diário foi superior à média mensal.  

Questão 4 - Percentual de Representação
Implemente um programa que calcula o percentual de representação de cada estado no faturamento mensal total de uma distribuidora.

Questão 5 - Inversão de String
Implemente um método que inverte os caracteres de uma string fornecida.

Alterações Importantes
Antes de rodar os testes, não se esqueça de alterar o caminho do arquivo dados.json para refletir o local correto em sua máquina. O arquivo dados.json deve estar dentro da pasta Resources/.

Se você tiver alguma dúvida, sinta-se à vontade para abrir uma issue no repositório ou entrar em contato.
