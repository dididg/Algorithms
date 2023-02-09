public static class BinarySearch
{
    public static bool Find(int[] ints, int k)
    {
        int left = 0;
        int right = ints.Length - 1;
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (ints[middle] == k)
            {
                return true;
            }
            else if (ints[middle] < k)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var k = int.Parse(args[0]);
        var ints = args.Skip(1).Select(int.Parse).ToArray();
        Console.WriteLine(BinarySearch.Find(ints, k));
    }
}