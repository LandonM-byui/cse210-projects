public class Dice
{
    private Random _rand = new Random();
    private int _d;

    public Dice (int dNum)
    {
        _d = dNum;
    }

    public int roll(int amt, int mod = 0, bool adv = false)
    {
        int result = 0;
        for (int i = 0; i <amt; i++)
        {
            int roll = _rand.Next(1,_d+1);
            if (adv)
            {
                int roll2 = _rand.Next(1,_d+1);
                if (roll2 > roll)
                {
                    roll = roll2;
                }
            }
            result += roll;
        }
        result += mod;
        return result;
    }

}