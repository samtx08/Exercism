using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    private static bool IsGreekLowercase(char c) => Regex.IsMatch(c.ToString(), @"[α-ω]+");
    public static string Clean(string identifier){
        StringBuilder cleanString = new StringBuilder();
        var isAfterDash = false;
        foreach(var character in identifier){
            cleanString.Append(character switch{
                _ when IsGreekLowercase(character) => default,
                _ when isAfterDash => char.ToUpperInvariant(character),
                _ when char.IsWhiteSpace(character) => '_',
                _ when char.IsControl(character) => "CTRL",
                _ when char.IsLetter(character) => character,
                _ => default,
            });
        isAfterDash = character.Equals('-');
        }
    return cleanString.ToString();
    }
}
