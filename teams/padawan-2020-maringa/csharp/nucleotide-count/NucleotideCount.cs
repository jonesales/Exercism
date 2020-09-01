using System;
using System.Collections.Generic;

public static class NucleotideCount
{

    public static IDictionary<char, int> Count(string sequence)
    {
       IDictionary<char, int> List = new Dictionary<char, int>();

        int countA = 0;
        int countT = 0;
        int countC = 0;
        int countG = 0;


        foreach (var x in sequence) 
        {
            if (x == 'A')
                countA++;
            else if (x == 'T')
                countT++;
            else if (x == 'C')
                countC++;
            else if (x == 'G')
                countG++;
            else 
            {
                throw new ArgumentException();
            }
        }

        List.Add('A', countA);
        List.Add('T', countT);
        List.Add('C', countC);
        List.Add('G', countG);

        return List;
    }


}