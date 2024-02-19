# LazyIterationTest
**Descrição**

LazyIterationTest é um projeto de benchmark em C# que demonstra a eficiência da iteração preguiçosa usando IEnumerable e yield return comparada à iteração convencional. O foco principal está em processar dados de arquivos, destacando as diferenças em termos de desempenho e uso de memória.

**Pré-requisitos**
- .NET 8
- Um ambiente de desenvolvimento como Visual Studio ou VS Code
  
**Configuração**
- Clone o repositório para o seu ambiente local.
- Atualize o caminho do diretório da pasta Files no arquivo de recursos Resource.resx, chave "DataDirectory".

**Execução**

Compile o projeto em mode de release ou utilize o comando "dotnet run -c Release".

Os benchmarks comparam dois métodos:
- ProcessFile: Processamento convencional de arquivos.
- ProcessFileLazy: Processamento preguiçoso de arquivos.
  
Os resultados ilustram as diferenças em termos de tempo de execução e memória alocada.

**Contribuindo**
Contribuições são bem-vindas. Para contribuir:

- Faça um fork do repositório.
- Crie uma branch para sua feature.
- Faça suas alterações, commit e pushpara uma nova branch.
- Abra um Pull Request.
