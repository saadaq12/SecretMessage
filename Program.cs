using System;

class Program
{
    static void Main()
    {
        // Create objects for encoder and decoder
        MessageEncoder encoder = new MessageEncoder();
        MessageDecoder decoder = new MessageDecoder();

        // Menu loop continues until user chooses Exit
        while (true)
        {
            Console.WriteLine("\n=== 🔐 Secret Message Machine ===");
            Console.WriteLine("1. Encode message");
            Console.WriteLine("2. Decode message");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            // Use switch-case for menu choices
            switch (choice)
            {
                case "1":
                    // Ask user for message to encode
                    string messageToEncode = InputHelper.ReadString("Enter message to encode: ");
                    string encoded = encoder.Encode(messageToEncode);
                    Console.WriteLine($"Encoded message: {encoded}");
                    break;

                case "2":
                    // Ask user for message to decode
                    string messageToDecode = InputHelper.ReadString("Enter message to decode: ");
                    string decoded = decoder.Decode(messageToDecode);
                    Console.WriteLine($"Decoded message: {decoded}");
                    break;

                case "3":
                    Console.WriteLine("Goodbye, agent. 🕶️");
                    return;

                default:
                    Console.WriteLine("❌ Invalid choice, try again.");
                    break;
            }
        }
    }
}
