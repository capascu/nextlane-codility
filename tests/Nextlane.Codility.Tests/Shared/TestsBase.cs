using System.Collections.Generic;
using Nextlane.Codility.Shared.Abstractions;

namespace Nextlane.Codility.Tests.Shared;

internal static class TestsExtensions
{
    //[Theory]
    //[MemberData(nameof(GetTestData))]
    //public void Execution_returns_expected_result(TSelf data)
    //{
    //    ExecuteTest(data);
    //}

    //protected abstract void ExecuteTest(TSelf data);

    //public static TheoryData<TSelf> GetTestData<TSelf>()
    //    where TSelf : ITestable<TSelf>
    //{
    //    TheoryData<TSelf> theoryData = new();

    //    foreach (var sample in TSelf.GetSamples())
    //    {
    //        theoryData.Add(sample);
    //    }

    //    return theoryData;
    //}

    internal static TheoryData<TSelf> ConvertToTestData<TSelf>(this IEnumerable<TSelf> samples)
        where TSelf : ITestable<TSelf>
    {
        TheoryData<TSelf> theoryData = new();

        foreach (var sample in samples)
        {
            theoryData.Add(sample);
        }

        return theoryData;
    }
}
