using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Numerics;

class Testing
{
    private static void Main(string[] args)
    {
        Game my_game = new Game();
        int total = my_game.Run_Game();
        Debug.Assert(total <=18 &&  total >=3) ;
    }
}

class Dice
{
    private int D_Value = 0;
    public int value 
    {
        get { return D_Value; }
        set { D_Value = value; }
    }

    public int Roll()
    {
        Random rnd = new Random();
        return rnd.Next(1,7);
    }

}

class Game
{
    public int Run_Game()
    {
        Dice dice1 = new Dice();
        dice1.value = dice1.Roll();
        Debug.Assert(dice1.value >= 1 && dice1.value<=6);
        Dice dice2 = new Dice();
        dice2.value = dice2.Roll();
        Debug.Assert(dice2.value >= 1 && dice2.value <= 6);
        Dice dice3 = new Dice();
        dice3.value = dice3.Roll();
        Debug.Assert(dice2.value >= 1 && dice2.value <= 6);
        return dice1.value + dice2.value + dice3.value;
    }
}