# Explicação

Este exemplo demonstra o problema de um cliente que precisa orquestrar diretamente múltiplos subsistemas de áudio e vídeo para converter um arquivo.
A solução ainda não usa o Facade, por isso o cliente fica exposto aos detalhes internos de cada classe e ao fluxo de chamadas.

### Problema

O cliente precisa conhecer as chamadas exatas aos subsistemas para executar a conversão:
- verificar o formato do arquivo de vídeo
- extrair ou preparar o áudio
- converter o áudio para MP3

Sem o Facade, o código cliente se torna acoplado ao processo e à API de cada subsistema.
Isso dificulta a manutenção, a reutilização e a evolução da lógica de conversão.

### Solução

Com o Facade, podemos encapsular essas operações em uma interface simples e unificada.
O cliente passa apenas o nome do arquivo para o Facade e não precisa saber quantos subsistemas existem ou em que ordem chamá-los.

No exemplo:
- `problem/Program.cs` mostra a implementação do problema, onde o cliente chama `VideoFile` e `MP3Converter` diretamente
- `solution/Facade/AudioVisualSystemFacade.cs` apresenta a implementação da solução, que oculta os detalhes da conversão

### Quando usar

Use Facade quando você precisa:

- simplificar o acesso a um conjunto de classes complexas ou de baixo nível
- reduzir o acoplamento entre o cliente e múltiplos subsistemas
- fornecer uma interface mais legível e coesa para operações de alto nível

### Quando NÃO usar

Não use Facade quando a funcionalidade já está encapsulada em uma interface simples ou quando não há um conjunto claro de subsistemas a unificar.
Nesse caso, o Facade apenas adicionaria uma camada extra sem trazer benefícios.
