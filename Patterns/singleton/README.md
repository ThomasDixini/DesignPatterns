# Singleton Pattern

## Problema

A criação descontrolada de instâncias de recursos caros ou compartilhados,
como conexões com banco de dados, loggers ou gerenciadores de configuração,
gera dois problemas principais:

- **Desperdício de recursos**: cada `new` instancia um objeto custoso do zero
- **Estado inconsistente**: instâncias diferentes podem ter configurações
  divergentes, causando comportamento imprevisível

## Solução

O Singleton garante que uma classe tenha apenas uma instância durante toda
a vida da aplicação, centralizando o acesso a um único ponto.

O mecanismo tem três partes:
- **Construtor privado** impede que código externo crie novas instâncias
- **Campo estático `_instance`** armazena a única instância criada
- **Método estático `GetInstance()`** cria a instância na primeira chamada
  e retorna a mesma em todas as chamadas seguintes

Para verificar, rode o projeto e compare os `GetHashCode()` dos dois objetos
`logger` o valor será idêntico, confirmando que é a mesma instância.

## Alternativa em .NET

O `AddSingleton` do ASP.NET Core resolve o mesmo problema sem esses defeitos:

```csharp
builder.Services.AddSingleton<ILogger, Logger>();
```

O container gerencia a instância única, o construtor continua público
e nos testes você injeta um mock normalmente.

Esse é exatamente o padrão usado no `RabbitMqPublisher` do projeto
[event-driven-dotnet](https://github.com/ThomasDixini/event-driven-dotnet)
a conexão com RabbitMQ é cara de criar e deve ser reutilizada, mas registrada
via DI em vez do Singleton clássico.

## Quando NÃO usar

Quando o objeto não tem estado compartilhado ou não é custoso de criar.
Prefira sempre a injeção de dependência com `AddSingleton` ao Singleton
clássico em projetos .NET modernos.