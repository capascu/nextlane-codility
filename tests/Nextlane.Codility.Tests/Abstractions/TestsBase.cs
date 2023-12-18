using Nextlane.Codility.Shared.Abstractions;

namespace Nextlane.Codility.Tests.Abstractions;

public abstract class TestsBase<TSelf>
    where TSelf : ITestable<TSelf>
{
    public static TheoryData<TSelf> GetTestData()
    {
        TheoryData<TSelf> theoryData = new();

        foreach (var sample in TSelf.GetSamples())
        {
            theoryData.Add(sample);
        }

        return theoryData;
    }

    protected static void EnsureIsNotTheAssessment()
    {
        const bool isTheAssessment = true; // ToDo: set the value

        isTheAssessment.Should().BeFalse();
    }
}
