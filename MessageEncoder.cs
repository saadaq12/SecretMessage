using System;
using System.Text;

public class MessageEncoder
{
    //Encodes en meddelande som använder agent cipher
    public string Encode(string message)
    {
        // loopar genom varje tecken i meddelandet
        StringBuilder encoded = new StringBuilder();
        foreach (char c in message)
        {
            switch (char.ToUpper(c))
            {
                case 'A':
                    encoded.Append("@ ");
                    break;
                case 'B':
                    encoded.Append("3 ");
                    break;
                case 'C':
                    encoded.Append("! ");
                    break;
                case 'D':
                    encoded.Append("0 ");
                    break;
                case 'E':
                    encoded.Append("$");
                    break;
                case 'F':
           
                default:
                    // ignore other characters
                    break;
            }
        } return encoded.ToString();
    }
}