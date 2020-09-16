using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        if (Regex.IsMatch(statement, "?$") && Regex.IsMatch(statement, "^.[A-Z]"))
            return "Calm down, I know what I'm doing!";

        else if (Regex.IsMatch(statement, "?$"))
            return "Sure";

        else if (Regex.IsMatch(statement, "^.[A-Z]"))
            return "Whoa, chill out!";

        else if (statement == "")
            return "Fine. Be that way!";

        else
            return "Whatever.";
    }
}