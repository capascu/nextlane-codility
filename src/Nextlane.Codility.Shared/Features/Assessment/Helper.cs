namespace Nextlane.Codility.Shared.Features.Assessment; // Do not copy!!

public /*internal*/ static class Helper
{
    public /*internal*/ static int Get(this IEnumerable<int> input)
    {
        Print("imprimiendo");

        var values = input
            //.Distinct()
            .GroupBy(i => i)
            .ToDictionary(g => new KeyValuePair<int, int>(g.Key, g.Count()))
            .Keys
            .Count;

        return values;
    }

    public /*internal*/ static int GetDistinct(this IEnumerable<int> input) =>
        input
            .Distinct()
            .Count();

    private static void Print(string message) =>
        Console.WriteLine(message);

}
