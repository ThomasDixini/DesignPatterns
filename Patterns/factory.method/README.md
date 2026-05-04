# Explicação

Fiz a implementação de pattern seguindo o objetivo de criar diferentes tipos de implementações para envio de notificação. Para explicar e usar como base um exemplo real de um projeto que tenho.


### Problema 

Nosso sistema começou enviando apenas push notifications. 
Mas e um dia surgir a necessidade de suportar email e SMS também?

Sem o pattern, a lógica de criação ficaria assim:

if (tipo == "push") return new PushNotification();
else if (tipo == "email") return new EmailNotification();
else if (tipo == "sms") return new SmsNotification();

Isso quebra dois princípios:
- **SRP**: `NotificacaoService` acumula responsabilidade de 
  criar e enviar notificações
- **OCP**: a cada novo tipo, precisamos alterar código existente

Nossa lógica de notificação ficaria complexa e totalmente acoplada a nossa classe `NotificacaoService`, lidando somente com um tipo de notificação e aumentando sempre que novas forem adicionadas. Fazendo assim, qualquer 
alteração nessa lógica, impactar em todos os lugares do sistema que usam ela.

### Solução

O Factory Method define uma interface para criação do objeto 
(**INotificator**) e delega para subclasses/implementações 
concretas (Classes que herdam **INotification**) a decisão de qual objeto criar.

Quem chama o **INotificator** não sabe qual implementação recebe, só sabe que recebe algo que implementa **INotification**.

Para adicionar EMAIL: criamos **EmailNotificator** sem tocar 
em nada existente.

### Quando NÃO usar

Quando você tem apenas um tipo de objeto e a variação é 
improvável. O pattern adiciona complexidade, só vale quando 
a extensibilidade é um requisito real.