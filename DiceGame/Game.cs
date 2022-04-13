using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using DiceLib;
using static DiceGame.Print;
namespace DiceGame;
public class Game
{
    public static void GamePlay(Dice dice)
    {
        int counter = 0;
        PrintGame(counter);
        int userAnswer = 0;
        dice.Throw();
        while (userAnswer != dice.DiceValue)
        {
            userAnswer = GetAnswer();
            if (Convert.ToChar(userAnswer) == 'Y') // THIS DOESNT WORK NEED TO FIGURE IT OUT
            {
                break;
            }
            counter++;
            /* DEBUG WRITELINE
            Console.WriteLine("!!");
            Console.WriteLine($"Face number :" + dice.FaceNumber);
            Console.WriteLine($"Dice Value : " + dice.DiceValue);
            Console.WriteLine($"User Answer : {userAnswer}");
            Console.WriteLine("!!");
            */
            if (userAnswer > dice.DiceValue)
            {
                PrintGame(counter,"GO LOWER");
            }
            if (userAnswer < dice.DiceValue)
            {
                PrintGame(counter,"GO HIGHER");
            }
        }
        PrintVictory(counter);
        GetChoice();
    }
    public static Dice CreateDice(int faceNumber)
    {
        Dice dice = new Dice(faceNumber);
        return dice;
    }
    public static Dice CustomDice()
    {
        PrintCustom();
        Dice dice = new Dice(GetAnswer());
        return dice;
    }
    public static int GetAnswer()
    {
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }
    public static char GetChoice()
    {
        char answer = char.Parse(Console.ReadLine().ToUpper());
        return answer;
    }
    public static bool GetYes()
    {
        char answer = char.Parse(Console.ReadLine().ToUpper());
        if (answer == 'Y')
        {
            return true;
        }
        return false;
    }
}