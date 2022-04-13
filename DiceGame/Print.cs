using DiceLib;

namespace DiceGame;

public class Print
{
    public static void PrintStart()
    {
            Console.Clear();
            Console.WriteLine("*!WELCOME TO DICE GAME!*");
            Console.WriteLine("*----------------------*");
            Console.WriteLine("*----------------------*");
            Console.WriteLine("*PLAY DICE   ->[Y/N]---*");
            Console.WriteLine("*----------------------*");
    }
    public static void PrintChoice()
    {
        Console.Clear();
            Console.WriteLine("*---!MAKE A CHOICE!----*");
            Console.WriteLine("*----------------------*");
            Console.WriteLine("*PRE MADE DICE->[1]----*");
            Console.WriteLine("*CUSTOM DICE  ->[2]----*");
            Console.WriteLine("*----------------------*");
    }
    public static void PrintPreMade()
    {
        Console.Clear();
        Console.WriteLine("*---!MAKE A CHOICE!----*");
        Console.WriteLine("*6  FACE DICE ->[1]----*");
        Console.WriteLine("*24 FACE DICE ->[2]----*");
        Console.WriteLine("*64 FACE DICE ->[3]----*");
        Console.WriteLine("*----------------------*");
    }
    public static void PrintCustom()
    {
        Console.Clear();
        Console.WriteLine("*----!CUSTOM DICE!-----*");
        Console.WriteLine("*----------------------*");
        Console.WriteLine("*----------------------*");
        Console.WriteLine("*HOW MANY FACES?-------*");
        Console.WriteLine("*----------------------*");
        Console.Write("Answer --> ");
    }
    public static void PrintGame(int counter,string message ="--------",string message2 = "")
    {
        Console.Clear();
        Console.WriteLine($"*!GUESS THE DICE VALUE!*");
        Console.WriteLine($"*NUMBER OF TRIES->{counter}---*");
        Console.WriteLine($"*{message}--------------*");
        Console.WriteLine($"*----------------------*");
        Console.WriteLine($"*GIVE UP? [Y]----------*");
        Console.Write("Answer --> ");
    }
    
    public static void PrintVictory(int counter)
    {
        Console.Clear();
        Console.WriteLine($"*---!CONGRATULATION!---*");
        Console.WriteLine($"*-----!YOU DIT IT!-----*");
        Console.WriteLine($"*# OF TRIES->{counter}---------*");
        Console.WriteLine($"*PLAY AGAIN  ->[Y/N]---*");
        Console.WriteLine($"*----------------------*");
    }

}