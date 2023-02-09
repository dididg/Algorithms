public static class MagicStones
{
    public static IEnumerable<long> Combine(IEnumerable<long> stones)
    {
        var set = new HashSet<long>();
        foreach(var stone in stones)
        {
            var temp = stone;
            while (set.Contains(temp))
                set.Remove(temp++);
            set.Add(temp);
        }
        return set;
    }
}

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine($"Initial Magic Stones: {string.Join(", ", args)}");
        var combined = MagicStones.Combine(args.Select(s => long.Parse(s)));
        System.Console.WriteLine($"Combined Magic Stones: {string.Join(", ", combined)}");
    }
}