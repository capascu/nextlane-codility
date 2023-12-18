using Nextlane.Codility.Shared.Abstractions;

namespace Nextlane.Codility.Shared.ValueObjects;

using TInput = /*PrettyEnumerable<int>;  // */ int[]; //ToDo
using TOutput = int;

public sealed record AssessmentData(TInput Input, TOutput Output)
    : ITestable<AssessmentData>
    //: TestData<TInput, TOutput>(Input, Output), ITestable<AssessmentData>
    {
        public const bool IsTheAssessment = true; // ToDo: CHANGE

    public static IEnumerable<AssessmentData> GetSamples()
    {
        yield return new(Input: [1, 1, 2, 3], Output: 3);
        yield return GetPerformanceData();
    }

    //public static PrettyEnumerable<AssessmentData> GetSamples() =>
    //    GetData().Prettify();
    

    //public static IEnumerable<object[]> GetTestData() =>
    //    GetSamples()
    //        .ConvertToTestData();

    public static AssessmentData GetPerformanceData() =>
         new(Input: Enumerable.Range(1, 3).ToArray(), Output: 3);

    public override string ToString() =>
        $"{nameof(Input)}: [{string.Join(separator: ", ", values: Input)}] {nameof(Output)}: {this.Output}]";
    //$"""
    //    {nameof(Input)}: [{string.Join(separator: ", ", values: Input)}]
    //    {nameof(Output)}: {this.Output}]
    //""";
}
