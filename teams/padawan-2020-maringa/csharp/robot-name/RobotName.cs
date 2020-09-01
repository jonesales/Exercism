using System;
using System.Collections.Generic;

public class Robot
{
    private readonly Random randomV = new Random();
    private static HashSet<string> names = new HashSet<string>();

    public string Name { get; private set; }

    public Robot()
    {
        Reset();
    }

    public void Reset()
    {
        Name = GenerateName();
    }
    public string GenerateName()
    {
        string robot = "";
        do
        {
            for (int i = 0; i < 5; i++)
            {
                robot += (i < 2) ? ((char) randomV.Next(65, 90)).ToString() : randomV.Next(0, 9).ToString();
            }
        } while (!UniqueName(robot));
        return robot.ToString();
    }

    public bool UniqueName(string name)
    {
        return names.Add(name);
    }
}