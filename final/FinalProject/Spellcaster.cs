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
        _spellSlots[level] -= 1;
    }

    public void display()
    {
        foreach (KeyValuePair<int, int> slot in _spellSlots)
        {
            Console.Write($"{slot.Key}: {slot.Value} | ");
        }
        Console.WriteLine("");
    }
}