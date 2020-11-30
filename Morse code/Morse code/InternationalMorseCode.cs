using System;
using System.Collections.Generic;
using System.Text;

namespace Morse_code
{
    public class InternationalMorseCode
    {
        // · == 0, – == 1, " " == 5;

        // Think in CHAR or STRING ?
        // Note from Wikipedia: "The letters of a word are separated by a space of duration equal to three dots,
        // and the words are separated by a space equal to seven dots."

        // Consider Q codes

        // Consider abbreviations
        // Such as OM for Old Man

        // Consider prosigns

        // Consider having special highlighting for anything that could have more than one meaning like if "OM" comes up in a word or phrase could mean "Old Man".
        // Also highlighting "K"s since it could be a call for "OVER"

        public static Dictionary<char, string> internationalTextCharacters = new Dictionary<char, string>()
        {
            // Letters
            {'a', "01"},
            {'b', "1000"},
            {'c', "1010"},
            {'d', "100"},
            {'e', "0"},
            {'f', "0010"},
            {'g', "110"},
            {'h', "0000"},
            {'i', "00"},
            {'j', "0111"},
            {'k', "101"}, // Same as "over"/ Wikipedia: "Invitation to transmit after terminating the call signal."
            {'l', "0100"},
            {'m', "11"},
            {'n', "10"},
            {'o', "111"},
            {'p', "0110"},
            {'q', "1101"},
            {'r', "010"}, // Same as "ROGER"
            {'s', "000"},
            {'t', "1"},
            {'u', "001"},
            {'v', "0001"},
            {'w', "011"},
            {'x', "1001"},
            {'y', "1011"},
            {'z', "1100"},
            // Numbers
            {'0', "11111"},
            {'1', "01111"},
            {'2', "00111"},
            {'3', "00011"},
            {'4', "00001"},
            {'5', "00000"},
            {'6', "10000"},
            {'7', "11000"},
            {'8', "11100"},
            {'9', "11110"},
            // Punctuation
            {'.', "010101"},
            {',', "110011"},
            /*Make sure to test this one*/{'\'', "011110"},
            {'?', "001100"},
            {'!', "101011"},
            {'/', "10010"},
            {'(', "10110"},
            {')', "101101"},
            {'&', "01000"}, // Same as "wait" (Source Wikipedia)
            {':', "111000"},
            {';', "101010"},
            {'=', "10001"},
            {'+', "01010"}, // Same as "new page signal"
            {'-', "100001"},
            {'_', "001101"},
            {'"', "010010"},
            {'$', "0001001"},
            {'@', "011010"}

        };

        // Thinking about making the prosigns an object to hold the letter combination, phrase or word, explanation, and morse code.
        Dictionary<string, int> internationalProsigns = new Dictionary<string, int>()
        {
            // Capitial letters in comments signal no spaces between them.
            //// Adding 5 into the int because some prosigns include letter spacing, while others don't. 5 looks similuar to S and helps make sure to type a space marker on purpose.

            //
            {"END OF WORK", 000101},
            {"ERROR", 00000000},
            {"STARTING SIGNAL", 10101},
            // Wikidepida states that: "Single-line display may use printed "+"" for "New Page Signal".
            {"NEW PAGE SIGNAL", 01010}, // Same as '+'
            {"UNDERSTOOD", 00010},
            
            
            
            // Wiki Explanation: Used to precede the name or other identification of the calling station (Morse abbr.).
            {"THIS IS FROM", 10050}, // Same as 'd' 'e' NOTE: 5 Added for space

            // Wiki Explanation: Used for directional signaling lights, but not in radiotelegraphy.
            {"UNKNOWN STATION", 0101}, // Same as "AA" with NO spaces

            // Wiki Explanation: General-purpose response to any request or inquiry for which the answer is "nothing" or "none" or "not available" (Morse abbr.). Also means "I have no messages for you."
            {"NOTHING HEARD", 1050050100}, // Same as 'n' 'i' 'l' NOTE: 5s Added for spaces

            // Wiki Explanation: Means the last transmission has been received, but does not indicate the message was understood or will be complied with.
            {"ROGER", 010}, // Same as 'r'

            // Wiki Explanation: Invitation to transmit after terminating the call signal.
            {"OVER", 101}, // Same as 'k' 

            // Wiki Explanation: End of transmission / End of message / End of telegram. (Same as EC "end copy", and character +.)
            {"OUT", 10101}, // Same as "AR" with NO spaces

            // Wiki Explanation: Announcing station shutdown (Morse abbr.).
            {"CLOSING", 101050100}, // Same as 'c' 'l' NOTE: 5 Added for space

            // Wiki Explanation: General call to any station (Morse abbr.).
            {"CQ", 101051101}, // Same as 'c' 'q' NOTE: 5 Added for space

            // Wiki Explanation: General call to two or more specified stations (Morse abbr.).
            // Wikipedia left phrase/ word empty so using prosign.
            {"CP", 10105000}, // Same as 'c' 'p' NOTE: 5 Added for space

            // Wiki Explanation: What is the name or identity signal of your station? (Morse abbr.)
            // Wikipedia left phrase/ word empty so using prosign.
            {"CS", 10105000}, // Same as 'c' 's' NOTE: 5 Added for space

            // Wiki Explanation: "I must pause for a few minutes." Also means "I am engaged in a contact with another station [that you may not hear]; please wait quietly."
            {"WAIT", 01000}, // Same as '&'
            
            // Wiki Explanation: 
            //{"", },

            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", },
            
            // Wiki Explanation: 
            //{"", }
        };
    }
}
