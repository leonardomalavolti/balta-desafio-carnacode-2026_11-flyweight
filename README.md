![ES-6](https://github.com/user-attachments/assets/f45a9cd1-e873-4945-b771-caacc98d7a11)

# 🥁 CarnaCode 2026 - Desafio 11 - Flyweight

Oi, eu sou o **Leonardo Malavolti** e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻  

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

---

## 📚 Sobre este desafio

No desafio **Flyweight**, precisei resolver um problema clássico de alto consumo de memória em um editor de texto que precisa renderizar milhões de caracteres formatados.

Durante esse processo, trabalhei conceitos importantes como:

- ✅ Boas práticas de arquitetura
- ✅ Código limpo
- ✅ Princípios SOLID
- ✅ Separação de responsabilidades
- ✅ Otimização de memória em larga escala

---

## 🚨 Problema

Um editor de texto precisa renderizar milhões de caracteres.

Cada caractere possui propriedades de formatação:

- Fonte
- Tamanho
- Cor
- Negrito
- Itálico
- Sublinhado

Na abordagem ingênua:

- ❌ Um objeto completo é criado para cada caractere
- ❌ Strings como "Arial", "Black" e "12pt" são repetidas milhões de vezes
- ❌ Consumo excessivo de memória
- ❌ Criação massiva de objetos no heap
- ❌ Impacto em performance e Garbage Collection

### 📉 Impacto em escala

Em um documento com 1 milhão de caracteres:

- ~80 a 100 MB apenas para armazenar formatação repetida
- Alto custo de alocação e coleta de lixo
- Baixa eficiência de cache

---

## ✅ Solução com o Pattern Flyweight

O padrão **Flyweight** resolve esse problema separando:

### 🔹 Estado Intrínseco (compartilhável)
- Símbolo
- Fonte
- Tamanho
- Cor
- Estilos (Bold, Italic, Underline)

### 🔹 Estado Extrínseco (não compartilhável)
- Linha
- Coluna

A ideia central é:

👉 Compartilhar objetos que possuem o mesmo estado intrínseco  
👉 Manter apenas a posição como dado único

---

## 🧠 Como foi implementado

- `CharacterFlyweight` → mantém estado intrínseco
- `CharacterFactory` → gerencia pool de objetos compartilhados
- `CharacterContext` → contém estado extrínseco
- `Document` → gerencia renderização

Exemplo de uso:

```csharp
document.AddCharacter(
    'A',
    "Arial",
    12,
    "Black",
    false,
    false,
    false,
    1,
    1);
```

Se outro caractere possuir a mesma formatação, o mesmo Flyweight será reutilizado.

---

## 🎯 Benefícios da Implementação

✔ Redução drástica de uso de memória  
✔ Compartilhamento inteligente de estado  
✔ Melhor performance em documentos grandes  
✔ Menos objetos no heap  
✔ Melhor aproveitamento de cache  
✔ Separação clara entre estado intrínseco e extrínseco  

---

## 🧩 Conceitos reforçados

Durante esse desafio, reforcei principalmente:

- Pool de objetos
- Separação de responsabilidades
- Otimização de recursos
- Escalabilidade
- Padrões estruturais
- Pensamento orientado à performance

---

## 🏁 Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os **23 Design Patterns clássicos** em cenários reais.

Durante essa jornada, os participantes desenvolvem a capacidade de:

- Identificar problemas arquiteturais
- Aplicar padrões corretamente
- Melhorar escalabilidade
- Otimizar performance
- Evoluir maturidade técnica

---

## 📖 eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito:

👉 [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns)

---

## 📌 Veja meu progresso no desafio

🔗 [Incluir aqui o link do repositório central do CarnaCode]

---

🚀 Seguimos para o próximo padrão!
