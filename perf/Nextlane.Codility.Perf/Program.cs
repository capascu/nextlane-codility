global using BenchmarkDotNet.Attributes;
global using Nextlane.Codility.Shared.ValueObjects;
using BenchmarkDotNet.Running;
using Nextlane.Codility.Perf.Features;

try
{
    if (AssessmentData.IsTheAssessment)
    {
        BenchmarkRunner.Run<AssessmentBenchmark>();
    }
    else
    {
        var benchmarkAssembly = typeof(Program).Assembly;
        BenchmarkSwitcher.FromAssembly(benchmarkAssembly)
        .Run(args);
    }

    return 0;
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();

    return 1;
}
