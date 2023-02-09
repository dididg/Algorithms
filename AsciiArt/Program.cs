public static class AsciiArt
{
    public const string A = "   #\n  # #\n #####\n#     #\n";
    public const string B = "###\n#  #\n###\n#  #\n###\n";

    public static string PrintChar(char c)
    {
        switch(c)
        {
            case 'A':
                return A;
            case 'B':
                return B;
            case 'C':
            default:
                throw new NotImplementedException();
        }
    }

    public static char ScanChar(string s)
    {
        foreach(var c in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
            if (s == PrintChar(c))
                return c;
        return '?';
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var art = AsciiArt.PrintChar('B');
        Console.WriteLine(art);
        char c = AsciiArt.ScanChar(art);
        Console.WriteLine("corresponds to: " + c);
    }
}