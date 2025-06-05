using System;
using System.Collections.Generic;

class Program
{
    // Asks the user a question, displays multiple choice options, and checks the user's answer
    static bool AskQuestion(string question, List<string> choices, int answer)
    {
        Console.WriteLine(question); // Display the question

        // Display all available choices, numbered from 1
        for (int i = 0; i < choices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {choices[i]}");
        }

        // Get the user's input
        Console.Write("Your answer: ");
        string userInput = Console.ReadLine();

        // Compare the trimmed input with the correct answer (as string), return true if correct
        return userInput.Trim() == answer.ToString();
    }

    static void Main(string[] args)
    {
        // Define a list of questions where each question is a dictionary with:
        // - "q" (string): the question text
        // - "choices" (List<string>): list of answer choices
        // - "answer" (int): the correct choice number (1-based)
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

        // Shuffle the questions using the Fisher-Yates algorithm
        Random rng = new Random();
        for (int i = questions.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            var temp = questions[i];
            questions[i] = questions[j];
            questions[j] = temp;
        }

        int score = 0; // Initialize user score

        // Loop through each question in the shuffled list
        foreach (var q in questions)
        {
            // Extract and cast the question components from the dictionary
            string questionText = (string)q["q"];
            var choices = (List<string>)q["choices"];
            int answer = (int)q["answer"];

            // Ask the question and evaluate the answer
            if (AskQuestion(questionText, choices, answer))
            {
                Console.WriteLine("Correct!\n");
                score++; // Increment score for correct answer
            }
            else
            {
                Console.WriteLine("Wrong!\n");
            }
        }

        // Display the final score to the user
        Console.WriteLine($"Your score: {score}/{questions.Count}");
    }
}
