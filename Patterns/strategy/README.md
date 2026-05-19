# Explicação

Este exemplo implementa o Strategy Pattern para permitir a aplicação de diferentes estratégias de desconto
sem que o código cliente precise conhecer os detalhes de cada implementação.

No caso, temos um serviço de desconto genérico que depende de uma interface comum (`ICustomerDiscountStrategy`) e
recebe estratégias concretas para nenhum desconto, desconto de fidelidade, desconto com cupom, etc.

### Problema

Cada estratégia de desconto possui sua própria lógica de cálculo. Sem o Strategy Pattern, o código fica cheio de
`if-else` statements e verificações de tipo, causando:

- acoplamento entre a lógica de desconto e os tipos específicos de estratégia
- dificuldade para adicionar novas estratégias sem modificar o código existente
- impossibilidade de trocar estratégias em tempo de execução
- violação do princípio Open/Closed (aberto para extensão, fechado para modificação)

### Solução

O Strategy Pattern cria uma camada de abstração através de uma interface que define o contrato comum para todas
as estratégias. Assim, novas estratégias podem ser adicionadas sem alterar o código existente.

No exemplo:

- `ICustomerDiscountStrategy` define a operação comum `CalculateDiscount(decimal totalAmount)`
- `NoDiscountStrategy`, `LoyaltyDiscountStrategy` e `CouponDiscountStrategy` implementam essa interface
- `DiscountContext` recebe qualquer `ICustomerDiscountStrategy` e delega o cálculo
- A estratégia pode ser trocada em tempo de execução via `SetDiscountStrategy()`

Assim, o cliente usa sempre a mesma interface e as estratégias encapsulam a lógica de cálculo específica.

### Quando usar

Use Strategy quando:

- você tem múltiplas formas de fazer algo e precisa escolher qual usar em tempo de execução
- quer evitar `if-else` statements longos e acoplados ao tipo
- deseja adicionar novas estratégias sem modificar o código existente
- precisa encapsular comportamentos variáveis

### Quando NÃO usar

Não use quando você tem apenas uma forma de fazer algo ou quando a lógica é muito simples. Nesse caso,
o Strategy adicionaria complexidade desnecessária.

### Benefícios

- **Extensibilidade**: Novas estratégias podem ser adicionadas facilmente
- **Flexibilidade**: Estratégias podem ser trocadas em tempo de execução
- **Manutenibilidade**: Cada estratégia está isolada em sua própria classe
- **Testabilidade**: Cada estratégia pode ser testada isoladamente
