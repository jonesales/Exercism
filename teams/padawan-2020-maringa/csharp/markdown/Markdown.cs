using System;
using System.Text.RegularExpressions;

public static class Markdown
{
    private static string Wrap(this string text, string tag) => $"<{tag}>{text}</{tag}>";

    private static string Parse(string markdown, string delimiter, string tag) =>
        Regex.Replace(markdown, $"{delimiter}(.+){delimiter}", $"<{tag}>$1</{tag}>");

    private static string ParseLi(string markdown) => markdown.Substring(2).Wrap("li");

    private static string ParseParagraph(string markdown) => markdown.Wrap("p");

    private static string ListUlLI(string resultado) => Regex.Replace(resultado, "<li>.+</li>", "<ul>$0</ul>");



    private static string ParseHeader(string markdown)
    {
        var count = 0; foreach (char item in markdown) { if (item != '#') { break; } count++; }
        return markdown.Substring(count + 1).Wrap($"h{count}");
    }



    private static string ParseLine(string markdown)
    {
        markdown = Parse(markdown, "__", "strong");



        markdown = Parse(markdown, "_", "em");



        if (markdown.StartsWith("#"))
            return ParseHeader(markdown);



        return markdown.StartsWith("*") ? ParseLi(markdown) : ParseParagraph(markdown);
    }

    public static string Parse(string markdown)
    {
        string resultado = "";



        foreach (var item in markdown.Split('\n'))
        {
            resultado += ParseLine(item);
        }
        return ListUlLI(resultado);
    }
}


