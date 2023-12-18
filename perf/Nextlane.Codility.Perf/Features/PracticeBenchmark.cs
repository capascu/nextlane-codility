using Nextlane.Codility.Practice;
using NumbersHelper = Nextlane.Codility.Shared.Features.Practice.NumbersHelper;

namespace Nextlane.Codility.Perf.Features;

[MemoryDiagnoser]
public class PracticeBenchmark
{
    //[Params(1, 2, 3, 20, 100, 1_000)]
    //public int Limit { get; set; }

    //private static readonly int[] Numbers = PracticeData.GetPerformanceData().Input;
    private static readonly PrettyEnumerable<int> Numbers = AssessmentData.GetPerformanceData()
                                                            .Input
                                                            .Prettify();


    [Benchmark(Baseline = true)]
    public void GetSmallestPositiveNumber() =>
        _ = Numbers.GetSmallestPositiveNumber();

    [Benchmark]
    public void GetSmallestPositiveNumberHashSet() =>
        _ = Numbers.GetSmallestPositiveNumberWithHashSet();

    [Benchmark]
    public void GetSmallestPositiveNumberWithArraySort() =>
        _ = Numbers.GetSmallestPositiveNumberWithArraySort();

    [Benchmark]
    public void GetSmallestPositiveNumber_Latest() =>
        _ = NumbersHelper.GetSmallestPositiveNumber(Numbers);

    [Benchmark]
    public void GetSmallestPositiveNumberWithHashSet_Latest() =>
        _ = NumbersHelper.GetSmallestPositiveNumberWithHashSet(Numbers);
}
