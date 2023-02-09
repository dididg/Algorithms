public static class LuckyMoney
{
    public static int Compute(int money, int giftees)
    {
        if ((money / giftees) >= 8) return giftees;
        if (money < 8) return 0;
        if (money % 8 == 4 || money % 8 == 0) return (money / 8) - 1;
        return money / 8; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        int money = int.Parse(args[0]);
        int giftees = int.Parse(args[1]);
        var stdtoutWriter = Console.Out;
        Console.SetOut(Console.Error);
        int gifts = LuckyMoney.Compute(money, giftees);
        Console.SetOut(stdtoutWriter);
        Console.WriteLine(gifts);
    }
}