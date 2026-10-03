# calculadora-descontos-xunit

## Testes com xUnit

- `[Fact]`: testa um cenário fixo, sem parâmetros.
- `[Theory]`: testa o mesmo comportamento com diferentes conjuntos de dados, usando `[InlineData]`, onde podem ser repassado diversos parâmetros de forma mais simples

## Executar os testes

Na raiz do repositório, execute:

```bash
dotnet test
```

O comando restaura as dependências, compila os projetos e executa os testes.