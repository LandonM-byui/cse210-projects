public class Tracker
{
    private string _name;
    private List<Character> _charList;

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

        for( int i = 0; i < _charList.Count(); i++)
        {
            int max = 0;
            Character temp = null;
            foreach (Character c in _charList)
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
                _charList.Remove(temp);
            }
        }
        _charList.AddRange(tempList);
    }

    public void display()
    {
        foreach (Character c in _charList)
        {
            Console.WriteLine(c.getInfo());
        }
    }
}