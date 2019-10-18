using System;
class EntryPoint
{
    static void Main()//string[]args is not needed yet
    {
        //Primitive Data Types consist of a type, a label, and a value
        int age = 33;
        string firstName = "Prescott";
        string freeSpace = " ";

        //Use variables in case of changing information
        //If this was January 6, 2020, I would change the age value
        //And anytime I reference age, it would be 34
        //Instead of putting ("33") 

        Console.WriteLine(firstName + freeSpace + age);
    }
}
