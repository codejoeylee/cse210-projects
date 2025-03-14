using System;
using System.Collections.Generic;

class PromptGenerator
{
    List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What did you learn today?");
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What are you grateful for?");
        _prompts.Add("What did you do today that made you proud?");
        _prompts.Add("What are your goals for the next week?");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
