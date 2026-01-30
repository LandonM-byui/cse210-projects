public class PromptGen
{
    public List<string> _promts = new List<string>([
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What am I grateful for today?",
    "What is something I learned today?",
    "What good did I do in the world today?"]);

    public Random rnd = new Random();
    public string ReturnPrompt()
    {
        return _promts[rnd.Next(0, _promts.Count - 1)];
    }
}
