
using DesignPatternChallenge.Context;

Console.WriteLine("=== Editor com Flyweight ===\n");

var document = new Document();

string text = "HELLO HELLO HELLO";

for (int i = 0; i < text.Length; i++)
{
    document.AddCharacter(
        text[i],
        "Arial",
        12,
        "Black",
        false,
        false,
        false,
        1,
        i + 1);
}

document.RenderAll();
document.PrintStatistics();

Console.WriteLine("\n=== BENEFÍCIOS DO FLYWEIGHT ===");
Console.WriteLine("✔ Compartilhamento de estado intrínseco");
Console.WriteLine("✔ Redução massiva de uso de memória");
Console.WriteLine("✔ Melhor performance em larga escala");
Console.WriteLine("✔ Separação clara entre estado intrínseco e extrínseco");