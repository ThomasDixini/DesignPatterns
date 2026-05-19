# 📌 Objetivo do Repositório

Este repositório tem como objetivo o **estudo prático de Design Patterns em C#**, com foco em **problemas reais de design de software**, e não apenas em exemplos teóricos.

Cada padrão é apresentado seguindo a mesma abordagem:

- Um cenário problemático, com código propositalmente acoplado ou difícil de manter
- A aplicação do Design Pattern como solução
- Uma comparação clara entre antes e depois, destacando benefícios e trade-offs
- Observações sobre quando usar e quando evitar cada pattern

O foco do projeto é demonstrar raciocínio arquitetural, tomada de decisão e entendimento dos impactos de cada padrão no código, alinhado a práticas modernas como **baixo acoplamento, testabilidade e manutenção.**

## 📚 Padrões Implementados

### Padrões Criacionais (Creational)

#### 1. **Singleton**
- **Uso**: Garantir que uma classe tenha apenas uma instância
- **Problema**: Múltiplas instâncias causam inconsistência de estado
- **Solução**: Controlar a criação da instância dentro da própria classe
- **Quando usar**: Gerenciadores de configuração, conexões com banco de dados, loggers
- **Localização**: `Patterns/singleton/`

#### 2. **Factory Method**
- **Uso**: Criar objetos sem expor suas classes concretas
- **Problema**: O cliente fica acoplado às classes específicas
- **Solução**: Delegar a criação para uma factory
- **Quando usar**: Sistemas com múltiplas implementações de uma interface
- **Localização**: `Patterns/factory.method/`

#### 3. **Builder**
- **Uso**: Construir objetos complexos passo a passo
- **Problema**: Construtores com muitos parâmetros ficam ilegíveis
- **Solução**: Usar um builder para montar o objeto gradualmente
- **Quando usar**: Objetos com muitas configurações opcionais
- **Localização**: `Patterns/builder/`

### Padrões Estruturais (Structural)

#### 4. **Adapter**
- **Uso**: Adaptar interfaces incompatíveis
- **Problema**: Código cliente precisa conhecer múltiplas APIs diferentes
- **Solução**: Criar adaptadores que traduzem entre interfaces
- **Quando usar**: Integração com bibliotecas externas ou legacy code
- **Localização**: `Patterns/adapter/`

#### 5. **Decorator**
- **Uso**: Adicionar responsabilidades a um objeto dinamicamente
- **Problema**: Subclasses crescem exponencialmente para cada combinação de comportamento
- **Solução**: Envolver objetos em decoradores que estendem funcionalidade
- **Quando usar**: Adicionar comportamentos transversais (cache, logging, validação)
- **Localização**: `Patterns/decorator/`

#### 6. **Facade**
- **Uso**: Prover uma interface simplificada para um subsistema complexo
- **Problema**: Cliente precisa conhecer muitas classes e suas interações
- **Solução**: Criar uma facade que encapsula a complexidade
- **Quando usar**: Simplificar uso de bibliotecas ou subsistemas complexos
- **Localização**: `Patterns/facade/`

### Padrões Comportamentais (Behavioral)

#### 7. **Strategy**
- **Uso**: Encapsular algoritmos alternativos de forma intercambiável
- **Problema**: Múltiplos if-else statements acoplados ao tipo
- **Solução**: Criar estratégias que implementam uma interface comum
- **Quando usar**: Múltiplas formas de fazer algo e escolher em tempo de execução
- **Localização**: `Patterns/strategy/`

## 🚀 Como Usar Este Repositório

Cada padrão está organizado em duas pastas:

- **`problem/`**: Código com a abordagem problemática (anti-pattern)
- **`solution/`**: Código aplicando o Design Pattern

### Executar um exemplo:

```bash
# Navegar até o padrão desejado
cd Patterns/[pattern-name]/[problem ou solution]

# Executar com .NET
dotnet run [args-se-necessário]
```

### Analisar as diferenças:

1. Leia o arquivo `README.md` (ou `README.en.md` para inglês) do padrão
2. Compare o código em `problem/Program.cs` com `solution/`
3. Observe como a solução resolve os problemas listados

## 📖 Conceitos-Chave

- **Baixo Acoplamento**: Código independente de implementações específicas
- **Princípio Open/Closed**: Aberto para extensão, fechado para modificação
- **Princípio da Responsabilidade Única**: Cada classe tem uma razão para mudar
- **Injeção de Dependência**: Classes recebem suas dependências
- **Polimorfismo**: Comportamento diferente através de interfaces comuns

## 🎯 Objetivo de Aprendizado

Este projeto visa proporcionar:

- Compreensão prática de cada Design Pattern
- Reconhecimento de quando cada padrão se aplica
- Habilidade de implementar os padrões em C#
- Entendimento dos trade-offs e limitações
- Base sólida para tomada de decisão arquitetural

O projeto é voltado para aprendizado contínuo e para servir como material de referência para entrevistas, revisões técnicas e discussões sobre arquitetura de software.
