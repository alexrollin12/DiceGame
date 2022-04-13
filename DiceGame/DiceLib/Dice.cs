namespace DiceLib;

public class Dice
{ 
    private int _faceNumber ;

   public int FaceNumber
   {
       get => _faceNumber;
       private set
       {
           if (value < 2 || value > 120)
           {
               throw new ArgumentException("Invalide Face Value");
           }
           _faceNumber = value;
       }
   }
   public int DiceValue { get; set; }

    public Dice(int faceNumber)
    {
        FaceNumber = faceNumber;
        DiceValue = 1;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Dice other = (Dice) obj;
        return DiceValue.Equals(other.DiceValue) && FaceNumber.Equals(other.FaceNumber); //this.DiceValue.Equals(other.DiceValue) same same
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(DiceValue,FaceNumber);
    }

    public override string ToString()
    {
        return $"The dice with {FaceNumber} faces has a value of : {DiceValue}";
    }
    public void Throw()
    {
        Random random = new Random();
        this.DiceValue = random.Next(1, this.FaceNumber + 1);
    }

}
    