# Explicacao

Este exemplo implementa o Adapter Pattern para permitir o envio de notificações usando provedores diferentes
sem que o restante da aplicação precise conhecer os detalhes de cada implementação.

No caso, temos um serviço de notificação genérico que depende de uma interface comum (`INotificationService`) e
recebe adaptadores concretos para Expo Push e Firebase Cloud Messaging.

### Problema

Cada serviço de notificação possui sua própria API e formato de mensagem.
Sem o Adapter, o código cliente teria que conhecer e lidar com cada implementação diferente, causando:

- acoplamento entre a lógica de envio e provedores específicos
- duplicação de código para adaptar mensagens
- dificuldade para trocar ou adicionar novos provedores

### Solução

O Adapter cria uma camada de adaptação entre a interface usada pela aplicação e a implementação específica
do provedor.

No exemplo:

- `INotificationService` define a operação comum `SendNotification(string message)`
- `ExpoPushAdapter` e `FirebasePushAdapter` implementam essa interface
- `NotificationService` recebe qualquer `INotificationService` e delega a chamada

Assim, o cliente usa sempre a mesma interface e os adaptadores encapsulam a incompatibilidade de cada provedor.

### Quando usar

Use Adapter quando:

- você precisa integrar uma classe externa ou legado com uma interface diferente da usada pelo seu sistema
- quer evitar que o código cliente dependa diretamente de APIs específicas
- deseja trocar implementações sem alterar a interface do serviço

### Quando NÃO usar

Não use quando todas as implementações já compartilham a mesma interface ou quando não há necessidade de
adaptar incompatibilidades. Nesse caso, o Adapter adicionaria complexidade desnecessária.
