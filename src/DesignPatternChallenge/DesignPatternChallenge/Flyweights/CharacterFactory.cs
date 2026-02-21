namespace DesignPatternChallenge.Flyweights;

public class CharacterFactory
{
    private readonly Dictionary<string, ICharacterFlyweight> _characters
        = new();

    public ICharacterFlyweight GetCharacter(
        char symbol,
        string fontFamily,
        int fontSize,
        string color,
        bool isBold,
        bool isItalic,
        bool isUnderline)
    {
        string key = $"{symbol}_{fontFamily}_{fontSize}_{color}_{isBold}_{isItalic}_{isUnderline}";

        if (!_characters.ContainsKey(key))
        {
            _characters[key] = new CharacterFlyweight(
                symbol,
                fontFamily,
                fontSize,
                color,
                isBold,
                isItalic,
                isUnderline);
        }

        return _characters[key];
    }

    public int GetTotalFlyweights() => _characters.Count;
}
