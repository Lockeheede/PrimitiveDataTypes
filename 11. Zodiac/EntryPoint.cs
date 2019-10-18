using System;
using System.Text;
class EntryPoint
{
    static void Main()
    {
        Console.Title = "Zodiac Lovers";
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        //Changes the input and output of the console's encoding

        char theGeminiCharacter = '\u264A';
        char theCapricornCharacter = '\u2651';
        char theHeartCharacter = '\u2764';
        string freeSpace = " ";
        string newLineSpace = "\n";
        //Can't seem to find the right unicode process to make the zodiac signs. 
        //Solution: The output code console has an option (in the top right corner) that helps you change
        //The font in the properities (some font styles do not support the use of zodiac signs, or 
        //Other unicode characters). Find the one that works for you!

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(theCapricornCharacter + freeSpace + theHeartCharacter + freeSpace + freeSpace + theGeminiCharacter);
        Console.ResetColor();
    }

}