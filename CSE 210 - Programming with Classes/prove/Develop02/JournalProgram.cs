using System;
using System.Collections.Generic;

public class Journal
{
    private Dictionary<string, bool> prompts;
    private List<string> responses;

    public Journal()
    {
        prompts = new Dictionary<string, bool>
        {
            { "How was your day?", false },
            { "How is your family?", false },
            { "What was the weather like today?", false },
            { "What was fun today?", false },
            { "How was work today?", false }
        };

        responses = new List<string>();
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nMenu");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Exit");
    }

    public void DisplayEntry()
    {
        if (responses.Count == 0)
        {
            Console.WriteLine("\nNo journal entries yet.");
        }
        else
        {
            Console.WriteLine("\nJournal Entries:");
            foreach (var response in responses)
            {
                Console.WriteLine(response);
            }
        }
    }

    public void Write()
    {
        // Find unanswered questions
        var unansweredQuestions = new List<string>();
        foreach (var prompt in prompts)
        {
            if (!prompt.Value)
            {
                unansweredQuestions.Add(prompt.Key);
            }
        }

        if (unansweredQuestions.Count == 0)
        {
            Console.WriteLine("\nNo more prompts available.");
            return;
        }

        Random random = new Random();
        string randomQuestion = unansweredQuestions[random.Next(unansweredQuestions.Count)];
        prompts[randomQuestion] = true; // Mark the prompt as answered
        Console.WriteLine($"\n{randomQuestion}");

        string answer = Console.ReadLine().Trim();

        // Ensure the answer is not empty
        while (string.IsNullOrEmpty(answer))
        {
            Console.WriteLine("Response cannot be empty.");
            answer = Console.ReadLine().Trim();
        }

        string date = DateTime.Now.ToString("dd/MM/yyyy");
        responses.Add($"Date: {date} - Prompt: {randomQuestion} - {answer}");
    }

    public void Run()
    {
        while (true)
        {
            ShowMenu();
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine().Trim();

            if (choice == "1")
            {
                Write();
            }
            else if (choice == "2")
            {
                DisplayEntry();
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nExiting the journal. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.");
            }
        }
    }

    // Main method to run the journal program
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.Run();
    }
}
