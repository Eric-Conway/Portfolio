using System;
using System.Collections.Generic;
using System.Text;

namespace Morse_code
{
    public static class Methods
    {
        public static void TranslateTextToCode()
        {
            string userText = Console.ReadLine();
            for (int i = 0; i < userText.Length; i++)
            {
                char currentCharacter = userText[i];
                Console.WriteLine(InternationalMorseCode.internationalTextCharacters[currentCharacter]);
            }
            
        }
    }
}
