using DiceLib;
using static DiceLib.Dice;
using static DiceGame.Game;
using static DiceGame.Print;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintStart();
                if (GetYes())
                {
                    PrintChoice();
                    switch (GetChoice())
                    {
                        case '1':
                        {
                            PrintPreMade();
                            switch (GetChoice())
                            {
                                case '1':
                                {
                                    GamePlay(CreateDice(6));
                                    break;
                                }
                                case '2':
                                {
                                    GamePlay(CreateDice(12));
                                    break;
                                }
                                case '3':
                                {
                                    GamePlay(CreateDice(24));
                                    break;
                                }
                            }
                            break;
                        }
                        case '2':
                        {
                            GamePlay(CustomDice());
                            break;
                        }
                    }
                }
            }
        }
    }
}