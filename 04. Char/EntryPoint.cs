using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        char theCharacterX = 'x';

        System.Console.WriteLine(theCharacterX);
        //When using the ascii char, you have to use the hx code
        //Found in ascii tables, the hx code for the '+' sign is 2B

        char thePlusSign = '\u002B';
        //Use the code '\u0000' where the hx code replaces the 0000s depending on how many digits it is
        System.Console.WriteLine(thePlusSign);

        //You can also use unicode, but you need the right encoding settings and font type
        //For the console itself

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        //Changes the input and output of the console's encoding

        char theSpecialCharacter = '\u00F6';

        Console.WriteLine(theSpecialCharacter);

        char theGeminiCharacter = '\u264A';
        char theCapricornCharacter = '\u2651';
        char theHeartCharacter = '\u2764';
        string freeSpace = " ";
        //Can't seem to find the right unicode process to make the zodiac signs. 

        Console.WriteLine(theCapricornCharacter + freeSpace + theHeartCharacter + freeSpace + theGeminiCharacter);
    }
}

