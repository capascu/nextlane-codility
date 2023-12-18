using System.Collections;

namespace Nextlane.Codility.Shared.ValueObjects;

public sealed class PrettyEnumerable<T>(IEnumerable<T> value) : IEnumerable<T>
{
    //private readonly IEnumerable<T> _value = value;

    //private const int MaxToStringLength = 50;
    public IEnumerator GetEnumerator() =>
        ((IEnumerable)value).GetEnumerator();

    IEnumerator<T> IEnumerable<T>.GetEnumerator() =>
        value.GetEnumerator();

    public override string ToString() =>
        $"[{string.Join(", ", value)}]"; //[..MaxToStringLength];

    //public static implicit operator List<T>(PrettyEnumerable<T> prettyEnumerable) =>
    //    prettyEnumerable.value.ToList();

    //public static implicit operator T[](PrettyEnumerable<T> prettyEnumerable) =>
    //    prettyEnumerable._value.ToArray();

    //public static implicit operator PrettyEnumerable<T>(T[] enumerable) =>
    //    new(enumerable);
}