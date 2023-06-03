using System;

public class JawadGPT
{
    public static void Main(string[] args)
    {
        int TimsesSaidHello = 0;
        bool IsAskingToQuit = false;
        string Prompt = "";
        string[] HelloMessages = {"Placeholder1", "Placeholder2", "Placeholder3", "Placeholder4", "Placeholder5"};
        Console.WriteLine("Welcome! Begin by saying Hello!");
        while (true)
        {
            Prompt = Console.ReadLine();
            if (Prompt.ToUpper().Contains("HELLO"))
            {
                if (TimsesSaidHello >= 4)
                {
                    Console.WriteLine(HelloMessages[4]);
                }
                else
                {
                    Console.WriteLine(HelloMessages[TimsesSaidHello]);
                }

                TimsesSaidHello += 1;
            }
            else if (Prompt.ToUpper().Contains("NO")) {
                if (IsAskingToQuit == false) {
                    Console.WriteLine("I do not understand the keyword \"No\" without any context. Please provide one.");
                }
                else
                {
                    Console.WriteLine("Are you sure, you seem like you really wanted to quit!");
                }
            }
            else
            {
                Console.WriteLine("As an BETA AI language model, I do not comprehend any concept, idea and/or word besides : \n - Hello\n - No \n - Quit \n - Change language to [[language]]\nAny other word will be ignored.");
            }
        }
    }
}