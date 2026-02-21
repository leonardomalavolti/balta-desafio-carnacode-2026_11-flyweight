namespace DesignPatternChallenge.Flyweights;

public interface ICharacterFlyweight
{
    void Render(int row, int column);
    int GetMemorySize();
}
