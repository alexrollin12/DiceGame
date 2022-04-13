using DiceLib;

namespace MultiDiceLib;

public class MultiDice
{
    public List<Dice> DiceList { get; set; }

    public MultiDice(List<Dice> diceList)
    {
        DiceList = diceList;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
}