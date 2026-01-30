using System.IO; 
public class Journal

{
    public List<Entry> _entries = new List<Entry>();
    public void MakeEntry(string date, string prompt, string input)
    {
        Entry entry = new Entry();
        entry._date = date;
        entry._prompt = prompt;
        entry._userInput = input;
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry.ReturnDate()} - Prompt: {entry.ReturnPrompt()}");
            Console.WriteLine($"{entry.ReturnUserInput()}");
            Console.WriteLine("");            
        }
    }


    public void SaveEntries(string filename)
    {
           
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._userInput}");
            }
        }
    }
}