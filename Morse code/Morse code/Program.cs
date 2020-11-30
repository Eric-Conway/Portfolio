using System;

namespace Morse_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Morse code international\nType to see what text looks like translated to Morse code.\n(Press Enter to submit).");
            
            Methods.TranslateTextToCode();

            // Try Catch block to capture non supported symbols // And/Or have them ingnored


        }
    }
}
