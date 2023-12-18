namespace Nextlane.Codility.Shared.ValueObjects;

public static class PrettyEnumerableExtensions
{
    public static PrettyEnumerable<T> Prettify<T>(this IEnumerable<T> enumerable) =>
        new(enumerable);
}