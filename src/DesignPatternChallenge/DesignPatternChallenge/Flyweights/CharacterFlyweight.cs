namespace DesignPatternChallenge.Flyweights;

public class CharacterFlyweight : ICharacterFlyweight
{
    private readonly char _symbol;
    private readonly string _fontFamily;
    private readonly int _fontSize;
    private readonly string _color;
    private readonly bool _isBold;
    private readonly bool _isItalic;
    private readonly bool _isUnderline;

    public CharacterFlyweight(
        char symbol,
        string fontFamily,
        int fontSize,
        string color,
        bool isBold,
        bool isItalic,
        bool isUnderline)
    {
        _symbol = symbol;
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        _color = color;
        _isBold = isBold;
        _isItalic = isItalic;
        _isUnderline = isUnderline;
    }

    public void Render(int row, int column)
    {
        var style = "";
        if (_isBold) style += "B";
        if (_isItalic) style += "I";
        if (_isUnderline) style += "U";

        Console.WriteLine($"[{row},{column}] '{_symbol}' {_fontFamily} {_fontSize}pt {_color} {style}");
    }

    public int GetMemorySize()
    {
        return sizeof(char) + 32 + sizeof(int) + 32 + 3;
    }
}
