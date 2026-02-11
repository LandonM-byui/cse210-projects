using System.ComponentModel.DataAnnotations;

public class Reference
{
    private string _reference;

    private List<Verse> _verses = new List<Verse>();

    public Reference(string reference, string verse)
    {
        _reference = reference;
        Verse v = new Verse(verse);
        _verses.Add(v);
    }

    public Reference(string reference, List<string> verses)
    {
        _reference = reference;
        foreach (string s in verses)
        {
            Verse v = new Verse(s);
            _verses.Add(v);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference);
        foreach (Verse v in _verses)
        {
            Console.WriteLine(v.ReturnVerse());
        }
    }

    public void ResetScriptures()
    {
        foreach (Verse v in _verses)
        {
            v.Reset();
        }
    }

    public void ToggleBlanks(int num, bool mem)
    {
        foreach (Verse v in _verses)
        {
            v.RandomBlanks(num, mem);
        }
    }
}