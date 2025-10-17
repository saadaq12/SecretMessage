using System;
using System.Text;

public class MessageDecoder
{
    // Decodes the encoded spy message back to readable text
    public string Decode(string codedMessage)
    {
        StringBuilder decoded = new StringBuilder();

        // foreach loop through every character
        foreach (char c in codedMessage)
        {
            // Reverse the substitution
            switch (c)
            {
                case '@': decoded.Append('A'); break;
                case '3': decoded.Append('E'); break;
                case '!': decoded.Append('I'); break;
                case '0': decoded.Append('O'); break;
                case '$': decoded.Append('S'); break;
                default: decoded.Append(c); break;
            }
        }

        return decoded.ToString();
    }
}
