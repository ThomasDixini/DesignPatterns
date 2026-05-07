# Explicação

Este exemplo demonstra o Decorator Pattern aplicando funcionalidades adicionais a um repositório de agendamento sem alterar a classe concreta.

A ideia é encapsular comportamentos como cache e logging em classes decoradoras que implementam a mesma interface (`ISchedulesRepository`) e delegam a chamada ao objeto original.

### Problema

Sem o Decorator, adicionar novas responsabilidades ao repositório exigiria alterar `ScheduleRepository` diretamente ou criar subclasses para cada combinação de comportamento.
Isso causa:

- acoplamento entre a lógica de acesso a dados e comportamentos transversais;
- duplicação de código em classes semelhantes;
- dificuldade para combinar, trocar ou estender funcionalidades dinamicamente.

### Solução

O Decorator resolve isso separando o comportamento extra em classes independentes que envolvem (decoram) a implementação básica.

No exemplo:

- `ISchedulesRepository` define o contrato comum `GetScheduleById(int id)`;
- `ScheduleRepository` implementa o acesso padrão ao banco simulado;
- `CachingScheduleRepository` decora outra instância de `ISchedulesRepository` e adiciona cache;
- `LoggingScheduleDecorator` decora outra instância e adiciona registro de execução.

Assim, o cliente pode montar uma cadeia de decoradores com responsabilidades adicionais sem modificar a classe base, mantendo o código mais flexível e aberto a extensões.

### Quando NÃO usar

Quando você tem apenas um comportamento adicional fixo e sem
perspectiva de variação. Se o repositório sempre vai ter logging
e nunca vai mudar, adicionar o comportamento direto na classe
é mais simples que criar uma cadeia de decorators.

O Decorator vale quando a combinação de comportamentos é variável
ou quando os comportamentos precisam ser testados isoladamente.

### Exemplos reais

O middleware pipeline do ASP.NET Core é Decorator puro —
cada `app.Use()` envolve o próximo handler adicionando
comportamento (autenticação, CORS, logging) sem modificar
os handlers internos.

O `RabbitMqPublisher` do projeto event-driven-dotnet poderia
ser decorado com um `LoggingPublisherDecorator` que registra
cada evento publicado sem tocar na implementação original.