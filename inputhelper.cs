using System;

public static class InputHelper
{
    // Reads a string from the console with a prompt
    public static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}
