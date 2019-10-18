using System;
class EntryPoint
{
    static void Main()
    {
        string nameOfCharacter = "The Thief";
        string spellName = "Fireball";
        int damageTaken = 100;

        //You can build strings using placeholders and the string.Format() operator
        //The {0} {1} placeholders are then referenced once you use a comma outside of the quotations ""
        string damageReport = "The " + nameOfCharacter + " character took " + damageTaken + " damage from " + spellName;
        string damageReportV2 = string.Format("The {0} character took {1} damage from {2}", nameOfCharacter, damageTaken, spellName);
        string damageReportV21 = string.Format("The {0} character took {1} damage from {2}, and now the {0} character is dead.", nameOfCharacter, damageTaken, spellName);

        Console.WriteLine(damageReportV21);

        //Interpolation uses direct variables in the placeholder. Make sure to use the "$" before your string
        string damageReportV3 = $"The {nameOfCharacter} character took {damageTaken} damage from {spellName}";

        Console.WriteLine(damageReportV3);
    }
}

