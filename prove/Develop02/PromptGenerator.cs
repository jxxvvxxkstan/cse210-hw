using System;

public class PromptGenerator
{
    private static List<string>_prompts = new List<string>()
    {
        "\"How do I feel at the moment?\"",
        "\"What do I need more of in my life?\"",
        "\"What would make me happy right now?\"",
        "\"What is going right in my life?\"",
        "\"What am I grateful for? List at least 10 things.\"",
        "\"When did I experience joy this week?\"",
        "\"What's bothering me? Why?\"",
        "\"What are my priorities at the moment?\"",
        "\"What do I love about myself?\"",
        "\"What's draining my energy? How can I reduce or cut it out?\""
    };
    public static string PromptRandomizer()
    {
        Random random = new Random();
        int _index = random.Next(0,_prompts.Count);
        string randomPrompt = _prompts[_index];
        return randomPrompt;
    }
}