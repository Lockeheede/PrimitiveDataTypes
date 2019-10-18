using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        float somePointNumber = 31425673458.4569f;
        //Don't forget to put the f suffix
        //Floats have 4 values: data type, name, number and suffix

        System.Console.WriteLine(somePointNumber);

        //High numbers in floats only go up 7 digits. Anything higher has an E+n
        //With E being 10 and n being the power
        //ie: E+13 = 10 ^ 13
        //Note: the decimial has to be 7 digits after the period

        //Calculate the area of a circle
        float piNumber = 3.14f;
        float circumferenceOfCircle = 461f;

        float areaOfCircle = piNumber * circumferenceOfCircle * circumferenceOfCircle;

        Console.WriteLine(areaOfCircle);

        float fMin = float.MinValue;
        float fMax = float.MaxValue;

        Console.WriteLine(fMin.ToString("f"));
        Console.WriteLine(fMax.ToString("f"));
        //Use the ToString method to output the entire value, but still with 
        //the E+n value after 7 digits

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;
        //The suffix for doubles is d, 15-16 digits precision

        Console.WriteLine(doubleMin.ToString("f"));
        Console.WriteLine(doubleMax.ToString("f"));

        decimal decMin = decimal.MinValue;
        decimal decMax = decimal.MaxValue;
        //The decimial has 28-29 digits precision but doesn't add aditional 0s in precision
        //Decimial suffix is m

        Console.WriteLine(decMin.ToString("f"));
        Console.WriteLine(decMax.ToString("f"));

    }
}

