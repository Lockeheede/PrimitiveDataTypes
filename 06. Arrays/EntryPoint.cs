using System;

class EntryPoint
{
    static void Main()
    {
        int[] numbers = new int[5];
        numbers[0] = 4;
        numbers[1] = 77;
        numbers[2] = 100;
        numbers[3] = 33;
        numbers[4] = 36;

        Console.WriteLine(numbers[2]);
        //Place a break point by clicking the left side of the code, by the lined number
        //Then press F5 to Debug. The Local tab will show the numbers and its values & type

        //Another way to use arrays
        string[] ninjas = { "Leo", "Ralph", "Mikey", "Donnie" };
        Console.WriteLine(ninjas[2]);

        string[] fruits = new string[5];

        fruits[0] = "banana";
        fruits[1] = "strawberry";
        fruits[2] = "orange";
        fruits[3] = "watermellon";
        fruits[4] = "kiwi";

        //One dimensional arrays take the whole part of the item in the index
        //This prints strawberry, see below
        Console.WriteLine(fruits[1]);

        //2Dimensional Arrays work where using the 2nd index is a part of the first index. See below
        //In order to get the w from kiwi
        Console.WriteLine(fruits[4][2]);

        //To change something inside of an index to something else
        fruits[0] = "blueberries";
        Console.WriteLine(fruits[0]);

    }
}

