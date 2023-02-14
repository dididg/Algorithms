using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution {
    static void Main(String[] args) {
        var n = int.Parse(Console.ReadLine());
        var sb = new StringBuilder();
        for(var i = 0; i < n; i++)
            sb.Append(Console.ReadLine());
        var tags = new HashSet<string>(FindTags(sb.ToString()));
        var ordered = from tag in tags orderby tag select tag;
        Console.WriteLine(string.Join(";", ordered));
    }
    
    private static IEnumerable<string> FindTags(string html)
    {
        var regex = @"(?<=<\s*)(\w+)(?=.*\s*(/\s*>|>.*<\s*/\s*\1\s*>))";
        return Regex
            .Matches(html, regex)
            .Select(m => m.ToString());
    }
}
