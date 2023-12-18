using Nextlane.Codility.Assessment;
using Helper = Nextlane.Codility.Shared.Features.Assessment.Helper;

namespace Nextlane.Codility.Perf.Features;

[MemoryDiagnoser]
public class AssessmentBenchmark
{
    //[Params(1, 2, 3, 20, 100, 1_000)]
    //public int Limit { get; set; }

    //private static IEnumerable<int> Data2 = AssessmentData.GetPerformanceData().Input;
    private static readonly PrettyEnumerable<int> Input = AssessmentData.GetPerformanceData()
                                                            .Input
                                                            .Prettify();

    [Benchmark(Baseline = true)]
    public void Get() =>
        _ = Input.Get();

    [Benchmark]
    public void GetDistinct() =>
        _ = Input.GetDistinct();

    [Benchmark]
    public void Get_Latest() =>
        _ = Helper.Get(Input);

    [Benchmark]
    public void GetDistinct_Latest() =>
        _ = Helper.GetDistinct(Input);
}
