public class Word
{
    private string _word;
    private string _blanks;
    private bool _blank = false;
    
    public Word(string word)
    {
        _word = word;
        for(int i = 0; i < _word.Length ; i++)
        {
            _blanks += "_";
        }
    }

    public string ReturnWord()
    {
        if (_blank)
        {
            return _blanks;
        }
        else
        {
            return _word;
        }
    }

    public bool IsBlank()
    {
        return _blank;
    }

    public void ToggleSpace()
    {
        if (_blank)
        {
            _blank = false;
        }
        else
        {
            _blank = true;
        }
    }
}