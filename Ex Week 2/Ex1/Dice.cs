using System;

class Dice
{
    private int sides;
    private static Random rnd = new Random();

    public Dice(int sides)
    {
        this.sides = sides;
    }

    public int Roll()
    {
        return rnd.Next(1, sides + 1);
    }

    public int GetSides()
    {
        return sides;
    }
}
