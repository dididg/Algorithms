public static class ClosestToZero
{
    public static int Find(IEnumerable<int> ts)
    {      
        if (ts.Count() == 0) return 0;
        var posMin = int.MaxValue;
        var negMin = int.MinValue;
        foreach(var temp in ts)
        {
            if (temp < 0) negMin = Math.Max(negMin, temp);
            if (temp > 0) posMin = Math.Min(posMin, temp);
            if (temp == 0) return 0;
        }
        if (posMin == -negMin) return posMin;
        if (-posMin > negMin) return posMin;
        return negMin;
    }
}


class Program
{
    static void Main(string[] args)
    {
        var ts = args.Select(s => int.Parse(s));
        var stdtoutWriter = Console.Out;
        Console.SetOut(Console.Error);
        int solution = ClosestToZero.Find(ts);
        Console.SetOut(stdtoutWriter);
        Console.WriteLine(solution);
    }
}