public class Tracker
{
    private string _name;
    private List<Character> _charList = new List<Character>();

    public Tracker(string name)
    {
        _name = name;
    }

    public void add(Character c)
    {
        _charList.Add(c);
    }

    public void remove(int num)
    {
        _charList.RemoveAt(num);
    }

    public void order()
    {
        List<Character> tempList = [];
        List<Character> expendableList = [];
        foreach (Character c in _charList)
        {
            expendableList.Add(c);
        }
        for( int i = 0; i < _charList.Count(); i++)
        {
            int max = 0;
            Character temp = null;
            foreach (Character c in expendableList)
            {
                if (c.getInitiative() > max)
                {
                    temp = c;
                    max = c.getInitiative();
                }
            }
            if (temp != null)
            {
                tempList.Add(temp);
                expendableList.Remove(temp);
            }
        }
        _charList.Clear();
        _charList.AddRange(tempList);
    }

    public void display()
    {
        int count = 1;
        foreach (Character c in _charList)
        {
            Console.WriteLine($"{count}. {c.getInfo()}");
            if (c.GetType() == typeof(LegendaryEnemy))
            {
                ((LegendaryEnemy)c).printLegendary();
            }
            count += 1;
        }
    }

    public Character returnCharacter(int pos)
    {
        return _charList[pos];
    }
}