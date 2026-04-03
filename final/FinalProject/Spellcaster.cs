public class Spellcaster
{
    private Dictionary<int, int> _spellSlots = new Dictionary<int, int>();

    public Spellcaster (List<int> slots)
    {
        int i = 1;
        foreach (int slot in slots)
        {
            _spellSlots.Add(i,slot);
            i ++;
        }
    }

    public void useSpell(int level)
    {
        if (_spellSlots[level] > 0)
        {
            _spellSlots[level] -= 1;   
        }
    }

    public string display()
    {
        string str = " Spells: ";
        foreach (KeyValuePair<int, int> slot in _spellSlots)
        {
            str += $" Lv {slot.Key}: {slot.Value} |";
        }
        return str;
    }
}