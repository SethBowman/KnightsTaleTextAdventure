namespace KnightsTaleTextAdventureUI.GameFunctions;

public static class UserInteraction
{
    public static void GameDialogue(string text)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static string GetUserInput(string prompt)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(prompt);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        return Console.ReadLine();
    }

    public static void DeathScreen(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Thread.Sleep(3000);
        Environment.Exit(0);
    }

    public static void PlayerInquiry(string[] questions, string[] answers)
    {
        var validChoice = false;
        var playerChoice = string.Empty;

        while (!validChoice)
        {
            var questionPrompt = "";

            for (int i = 0; i < questions.Length; i++)
            {
                questionPrompt += $"{i + 1}. {questions[i]}\n";
            }
            
            playerChoice = GetUserInput(questionPrompt);
            int choiceIndex;

            while (!int.TryParse(playerChoice, out choiceIndex))
            {
                GameDialogue("I don't understand your choice. Please choose a valid option.");
                playerChoice = GetUserInput(questionPrompt);
            }

            if (choiceIndex == questions.Length)
            {
                GameDialogue("Goodbye, brave Knight!");
                return;
            }
            else if (choiceIndex >= 1 && choiceIndex <= questions.Length)
            {
                GameDialogue(answers[choiceIndex - 1]);
            }
            else
            {
                GameDialogue("I don't understand your choice. Please choose a valid option.");
            }
        }
    }
}