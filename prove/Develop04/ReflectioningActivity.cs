public class ReflectioningActivity : Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."];
    private List<string> _usedPromts = [];
    private List<string> _questions = ["Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"];
    private List<string> _usedQuestions = [];
    private Random rand = new Random();
    public ReflectioningActivity(string des, string name) : base(des, name)
    {
        
    }

    public void RunReflectioning()
    {
        StartMessage();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        if (_prompts.Count() == 0)
            {
                foreach (string prompt in _usedPromts)
                {
                    _prompts.Add(prompt);
                }
                _usedPromts.Clear();
            }
        int num = rand.Next(0,_prompts.Count);
        Console.WriteLine($" --- {_prompts[num]} --- ");
        _usedPromts.Add(_prompts[num]);
        _prompts.RemoveAt(num);
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in...");
        CountDown(5);
        Console.Clear();

        int dur = GetDuration();
        while (dur > 0)
        {
            if (_questions.Count() == 0)
            {
                foreach (string quest in _usedQuestions)
                {
                    _questions.Add(quest);
                }
                _usedQuestions.Clear();
            }
            int num2 =  rand.Next(0,_questions.Count);
            Console.WriteLine($"> {_questions[num2]} ");
            _usedQuestions.Add(_questions[num2]);
            _questions.RemoveAt(num2);
            Loading();
            dur -= 6;
        }
        DisplayEnd();      
    }

}