using DiceLib;

namespace MultiDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dice> diceList = new List<Dice>(5);
            for (int i = 0; i < diceList.Capacity; i++)
            {
                diceList.Add(new Dice(6));
                diceList[i].Throw();
                Console.WriteLine(diceList[i].DiceValue);
            }
        }
    }
}