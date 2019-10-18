using System;
class EntryPoint
{
    static void Main()
    {
        string fruitJuice = "Orange Juice";

        string seperator = new string('-', 40); //A new string method uses which character followed by the number of times it is used

        Console.WriteLine(fruitJuice.Contains("O")); //Boolean operator to show if the index has certain data
        Console.WriteLine(seperator);
        Console.WriteLine(fruitJuice.IndexOf("j")); //Int operator to show where a data is in a string. -1 if it isn't there
        Console.WriteLine(seperator);
        Console.WriteLine(fruitJuice.LastIndexOf("e")); //Int operator to show where a data is in a string last. Used for multiple lettered words
        //ToUpper() and ToLower() are some tricks, too.

        Console.WriteLine(seperator);

        //Try a combination
        bool containsOrange = fruitJuice.ToUpper().Contains("ORANGE");
        //Remember to use a new variable of bool because you cannot convert ToUpper()
        //Which returns a string, to Contains() which returns a bool

        Console.WriteLine(containsOrange);
    }
}

