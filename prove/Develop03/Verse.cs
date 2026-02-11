public class Verse
{
    private List<Word> _verse = new List<Word>();
    public Random rnd = new Random();
    public Verse(string verse)
    {
        List<string> words = new List<string>(verse.Split(" "));

        foreach (string word in words)
        {
            Word w = new Word(word);
            _verse.Add(w);
        }
    }

    public string ReturnVerse()
    {
        string built_verse = "";

        foreach (Word word in _verse)
        {
            built_verse += word.ReturnWord() + " ";
        }
        return built_verse;
    }

    public void RandomBlanks(int blanks, bool mem)
    {
        int times = blanks;
        int blank = 0;
        foreach (Word word in _verse)
        {
            if (word.IsBlank() != mem)
            {
                blank += 1;
            }
        }
        if (blank < times)
        {
            times = blank;
        }
        do
        {
                Word word = _verse[rnd.Next(0, _verse.Count)];
                if (word.IsBlank() != mem)
                {
                    word.ToggleSpace();
                    times -= 1;
                }
        }
        while (times != 0);
    }

    public void Reset()
    {
        foreach (Word word in _verse)
        {
            if (word.IsBlank())
            {
                word.ToggleSpace();
            }
        }
    }
}