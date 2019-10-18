using System;

class EntryPoint
{
    static void Main()
    {
        int number = 5;
        string word = "5";
        string word2 = "0";
        char x = 'x';
        float pi = 3.14f;

        //When typecasting, some things can be properly converted
        //int to float can work
        float integer = number;
        //But float to int needs typecasting or it won't work at all
        //Even when it does work, it loses the .14 of the pi
        //Because int does not hold decimal points
        int floating = (int)pi;

        System.Console.WriteLine(integer);
        System.Console.WriteLine(floating);

        //When converting from a non-related data type to another, 
        //for instance string to int. You need to use the convert class
        int convertedInteger = Convert.ToInt32(word);
        Console.WriteLine(convertedInteger);
        //However, even still, the string must have an appropriate value
        //The word string needs to have a "5", not a "five" otherwise
        //The int would not read it properly

        //Parsing works similar to conversion. Except when using the null 
        //value. Using a null in parsing makes an exception value
        //while using it in conversion makes it a "0". Depending on 
        //what you are looking for, you may not want the value to be 
        //null or 0, so you make sure to track that deficiancy 
        int parsedString = int.Parse(word2);
        Console.WriteLine(word2);



    }
}

