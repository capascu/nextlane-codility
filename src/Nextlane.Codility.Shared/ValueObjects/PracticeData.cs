using Nextlane.Codility.Shared.Abstractions;

namespace Nextlane.Codility.Shared.ValueObjects;

public sealed record PracticeData(int[] Input, int Output)
    : ITestable<PracticeData>
    //: TestData<int[], int>(Input, Output), ITestable<PracticeData>
{
    public static IEnumerable<PracticeData> GetSamples()
    {
        yield return new PracticeData(Input: [1, 2, 3], Output: 4);
        yield return new PracticeData(Input: [4, -1], Output: 1);
        yield return new PracticeData(Input: [-1, 0], Output: 1);
        yield return new PracticeData(Input: [1, 1, 2, 3], Output: 4);
        yield return new PracticeData(Input: Enumerable.Range(-1, 100_002).ToArray(), Output: 100_001);
        yield return GetPerformanceData();
    }

    //public static IEnumerable<object[]> GetTestData() =>
    //    GetSamples()
    //        .ConvertToTestData();

    public static PracticeData GetPerformanceData() =>
        new(Input: Enumerable.Range(1, 3).ToArray(), Output: 4);

    public override string ToString() =>
        $"{nameof(Input)}: [{string.Join(separator: ", ", values: Input)}] {nameof(Output)}: {this.Output}]";
    //$"""
    //    {nameof(Input)}: [{string.Join(separator: ", ", values: Input)}]
    //    {nameof(Output)}: {this.Output}]
    //""";
}
