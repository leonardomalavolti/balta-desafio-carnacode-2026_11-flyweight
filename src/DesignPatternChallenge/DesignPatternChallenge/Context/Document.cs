using DesignPatternChallenge.Flyweights;

namespace DesignPatternChallenge.Context;

public class Document
{
    private readonly List<CharacterContext> _characters = new();
    private readonly CharacterFactory _factory = new();

    public void AddCharacter(char symbol, string font, int size,
        string color, bool bold, bool italic, bool underline,
        int row, int column)
    {
        var flyweight = _factory.GetCharacter(
            symbol, font, size, color, bold, italic, underline);

        _characters.Add(new CharacterContext(flyweight, row, column));
    }

    public void RenderAll()
    {
        foreach (var character in _characters)
            character.Render();
    }

    public void PrintStatistics()
    {
        Console.WriteLine("\n=== Estatísticas ===");
        Console.WriteLine($"Total de caracteres renderizados: {_characters.Count}");
        Console.WriteLine($"Flyweights criados: {_factory.GetTotalFlyweights()}");
    }
}