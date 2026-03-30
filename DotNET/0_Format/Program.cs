using System;

class Program
{
    private const string Line = "------------------------------";

    static void UpperFormat()
    {
        string str = "This is a string.";

        Console.WriteLine($"""
        {Line}
        Before : {str}
        After Upper : {$"[{str.ToUpper()}]"}
        After Lower : {$"[{str.ToLower()}]"}
        """);
    }

    static void TrimFormat()
    {
        string str = "      The Trim method string.     ";

        Console.WriteLine($"""
        {Line}
        Before : {str}
        After Normal Trim : {$"[{str.Trim()}]"}
        After Trim Start  : {$"[{str.TrimStart()}]"}
        After Trim End    : {$"[{str.TrimEnd()}]"}
        """);
    }
    
    static void ReplaceFormat()
    {
        string str = "The Replace method string.";

        Console.WriteLine($"""
        {Line}
        Before : {str}
        After Replace : {$"[{str.Replace("Replace", "Replaced")}]"}
        """);
    }

    static void SerchFormat()
    {
        string str = "The Search method string.";
        Console.WriteLine($"""
        {Line}
        Before : {str}
        Get Search : {$"[{str.Contains("Search")}]"}
        Get Search : {$"[{str.Contains("search")}]"}
        """);
    }

    static void Main()
    {
        UpperFormat();
        TrimFormat();
        ReplaceFormat();
        SerchFormat();
    }
}