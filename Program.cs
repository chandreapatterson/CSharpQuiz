using System;
using System.Collections.Generic;

class Program
{
    static bool AskQuestion(string question, List<string> choices, int answer)
    {
        Console.WriteLine(question);
        for (int i = 0; i < choices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {choices[i]}");
        }
        Console.Write("Your answer: ");
        string userInput = Console.ReadLine();
        return userInput.Trim() == answer.ToString();
    }

    static void Main(string[] args)
    {
        var questions = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object>
            {
                { "q", "Sample question red?" },
                { "choices", new List<string> { "Sample red 1", "Sample red 2", "Sample red 3", "Sample red 4" } },
                { "answer", 3 }
            },
            new Dictionary<string, object>
            {
                { "q", "Sample question blue?" },
                { "choices", new List<string> { "Sample blue 1", "Sample blue 2", "Sample blue 3", "Sample blue 4" } },
                { "answer", 2 }
            },
            new Dictionary<string, object>
            {
                { "q", "Sample question green?" },
                { "choices", new List<string> { "Sample green 1", "Sample green 2", "Sample green 3", "Sample green 4" } },
                { "answer", 2 }
            },
            new Dictionary<string, object>
            {
                { "q", "Sample question yellow?" },
                { "choices", new List<string> { "Sample yellow 1", "Sample yellow 2", "Sample yellow 3", "Sample yellow 4" } },
                { "answer", 4 }
            },
            new Dictionary<string, object>
            {
                { "q", "Sample question purple?" },
                { "choices", new List<string> { "Sample purple 1", "Sample purple 2", "Sample purple 3", "Sample purple 4" } },
                { "answer", 3 }
            },
            new Dictionary<string, object>
            {
                { "q", "Sample question orange?" },
                { "choices", new List<string> { "Sample orange 1", "Sample orange 2", "Sample orange 3", "Sample orange 4" } },
                { "answer", 1 }
            },
            new Dictionary<string, object>
            {
                { "q", "Sample question white?" },
                { "choices", new List<string> { "Sample white 1", "Sample white 2", "Sample white 3", "Sample white 4" } },
                { "answer", 2 }
            },
            new Dictionary<string, object>
            {
                { "q", "Sample question black?" },
                { "choices", new List<string> { "Sample black 1", "Sample black 2", "Sample black 3", "Sample black 4" } },
                { "answer", 1 }
            }
        };

        // Shuffle questions
        Random rng = new Random();
        for (int i = questions.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            var temp = questions[i];
            questions[i] = questions[j];
            questions[j] = temp;
        }

        int score = 0;
        foreach (var q in questions)
        {
            string questionText = (string)q["q"];
            var choices = (List<string>)q["choices"];
            int answer = (int)q["answer"];

            if (AskQuestion(questionText, choices, answer))
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!\n");
            }
        }

        Console.WriteLine($"Your score: {score}/{questions.Count}");
    }
}
