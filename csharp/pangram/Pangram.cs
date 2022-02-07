using System.Linq;
using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    { 
        /* 
        - Notes to self-
        Where() = 
        
        
        */
        return input.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
    }
}