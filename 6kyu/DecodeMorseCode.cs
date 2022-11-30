class MorseCodeDecoder
{
    public static string Decode(string morseCode)
    {
        string[] words = morseCode.Split("   ");
        string finalSentence = "";
        foreach (string word in words)
        {
            string[] characters = word.Split(" ");
            foreach (string morse in characters)
            {
                finalSentence += MorseCode.Get(morse);
            }
            finalSentence += " ";
        }
        finalSentence = finalSentence.Trim();
        return finalSentence;
    }
}