public static class Fibonacci
{
    public static IEnumerable<long> Enumerable()
    {
        var previous = 0L;
        var current = 1L;
        yield return previous;
        yield return current;
        while(true)
        {
            var next = current + previous;
            previous = current;
            current = next;
            yield return current;
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        foreach(var step in Fibonacci.Enumerable())
        {
            Console.Write($"{step} ");
            Console.ReadLine();
        }
    }
}