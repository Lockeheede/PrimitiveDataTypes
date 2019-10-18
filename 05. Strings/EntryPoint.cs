class EntryPoint
{
    static void Main()
    {
        string username = "admin";

        System.Console.WriteLine(username[0]);
        //putting the string and using the square brackets is known as indexing
        //The number, an interger, is used to reference the character that is being represented
        //By the number within the string. username[0] = 'a'; udername[1] = 'd'

        /*username[0].("b");
        System.Console.WriteLine(username[0]);
        Strings are immutable, this would not work*/
    }
}

