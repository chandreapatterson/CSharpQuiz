using System;
using System.Collections.Generic;
using QuizGenerator_Sn;


class Program
{
    // Asks the user a question, displays multiple choice options, and checks the user's answer
    static bool AskQuestion(Question question)
    {
        Console.WriteLine(question.Text);

        for (int i = 0; i < question.Choices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {question.Choices[i]}");
        }

        Console.Write("Your answer: ");
        string userInput = Console.ReadLine();

        return userInput.Trim() == question.AnswerIndex.ToString();
    }

    static void Main(string[] args)
    {
        // Create a list of Question objects
        var questions = new List<Question>
        {
            new Question("Sample question red?", new List<string> { "Sample red 1", "Sample red 2", "Sample red 3", "Sample red 4" }, 3),
            new Question("Sample question blue?", new List<string> { "Sample blue 1", "Sample blue 2", "Sample blue 3", "Sample blue 4" }, 2),
            new Question("Sample question green?", new List<string> { "Sample green 1", "Sample green 2", "Sample green 3", "Sample green 4" }, 2),
            new Question("Sample question yellow?", new List<string> { "Sample yellow 1", "Sample yellow 2", "Sample yellow 3", "Sample yellow 4" }, 4),
            new Question("Sample question purple?", new List<string> { "Sample purple 1", "Sample purple 2", "Sample purple 3", "Sample purple 4" }, 3),
            new Question("Sample question orange?", new List<string> { "Sample orange 1", "Sample orange 2", "Sample orange 3", "Sample orange 4" }, 1),
            new Question("Sample question white?", new List<string> { "Sample white 1", "Sample white 2", "Sample white 3", "Sample white 4" }, 2),
            new Question("Sample question black?", new List<string> { "Sample black 1", "Sample black 2", "Sample black 3", "Sample black 4" }, 1)
        };

        // Shuffle the questions
        Random rng = new Random();
        for (int i = questions.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            var temp = questions[i];
            questions[i] = questions[j];
            questions[j] = temp;
        }

        int score = 0;

        // Ask each question
        foreach (var q in questions)
        {
            if (AskQuestion(q))
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
