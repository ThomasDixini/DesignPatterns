# Explicação

Fiz a implementação desse pattern com o objetivo de simular a criação de variações de um relatório de vendas e também a simulação de filtragem daquilo que seria um IQueryable.


### Problema 

A quantidade de **overloads** no construtor cresce a cada novo parâmetro adicionado.
No exemplo foram apenas 3, mas com 10 parâmetros a assinatura se torna ilegível
e propícia a erros, o usuário pode passar valores na ordem errada ou não entender
o que um `null` no meio dos argumentos representa.

Uma alternativa seria usar subclasses, mas isso apenas troca um problema por outro:
uma nova subclasse para cada variação, tornando o sistema mais complexo a cada
nova implementação.

Em ambos os casos, o código cresce em complexidade sem ganhar clareza.


### Solução

Com o Builder, removemos o problema dos **overloads** separando a lógica 
de construção da regra de negócio da classe, seguindo o princípio de responsabilidade única.

Além disso, o pattern permite criar múltiplas variações do mesmo objeto e construir 
apenas as partes necessárias, sem forçar o cliente a conhecer os detalhes internos 
de como o objeto é montado.

### Quando NÃO usar

Não use Builder quando o objeto é simples e possui poucos parâmetros obrigatórios.
Nesse caso, um construtor tradicional é mais direto e menos verboso.

O Builder vale quando:
- há muitos parâmetros opcionais
- a construção envolve múltiplas etapas
- você precisa de múltiplas variações do mesmo objeto
