using DesignPatternChallenge.Flyweights;

namespace DesignPatternChallenge.Context;

public class CharacterContext
{
    private readonly ICharacterFlyweight _flyweight;
    private readonly int _row;
    private readonly int _column;

    public CharacterContext(ICharacterFlyweight flyweight, int row, int column)
    {
        _flyweight = flyweight;
        _row = row;
        _column = column;
    }

    public void Render()
    {
        _flyweight.Render(_row, _column);
    }
}