using System;
class EntryPoint
{
    static void Main()
    {
        //Making an int a string, you use the ToString()
        //Because ints and most other data types can't be referenced, or have access, that strings have

        int bigNumber = 751055;

        Console.WriteLine(bigNumber.ToString().Contains("7"));
        Console.WriteLine(bigNumber.ToString().IndexOf("0"));
        Console.WriteLine(bigNumber.ToString().LastIndexOf("5"));

        //Concatenation is when you add strings together. The '+' in this sense is concatenation
        string iLearn = "I am learning";
        string nameOfCourse = "C# Masterclass";
        string freeSpace = " ";

        string concatenated = iLearn + freeSpace + nameOfCourse + bigNumber.ToString();

        //The only thing being written down is the concatenated string
        Console.WriteLine(concatenated);

    }
}

