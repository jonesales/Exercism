using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public static List<int> List { get; set; } = new List<int>();

    public HighScores(List<int> list)
    {
        List = list;
    }

    public List<int> Scores() => List;


    public int Latest() => List.Last();


    public int PersonalBest() => List.Max();

    public List<int> PersonalTopThree() => List.OrderByDescending(x => x).Take(3).ToList();
  
}