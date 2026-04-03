public class PlayerCharacter : Character
{
    public PlayerCharacter(string name, int hp, int curHP = -1, int init = -10) : base (name, hp, curHP, init)
    {    }


    public override void takeDamage(int amt)
    {
        if (_curHP - amt < 0)
        {
            _curHP = 0;
        }
        else
        {
            _curHP -= amt;
        }
    }
}