using Nextlane.Codility.Shared.Features.Practice;

namespace Nextlane.Codility.Tests.Features;

[Trait(name: Traits.Type, value: Traits.PracticeLatest)]
public sealed class PracticeTests : TestsBase<PracticeData>
{
    //protected override void ExecuteTest(PracticeData data)
    //{
    //    AssessmentData.IsTheAssessment
    //        .Should()
    //        .BeFalse();

    //    // Arrange
    //    var solution = new Solution();

    //    // Act
    //    var result = solution.solution(data.Input);
    //    data.Input.GetSmallestPositiveNumber()
    //    // Assert
    //    result.Should().Be(data.Output);
    //}

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void GetSmallestPositiveNumber_returns_expected_result(PracticeData data)
    {
        EnsureIsNotTheAssessment();

        // Arrange
        (var numbers, var expected) = data;

        // Act
        var result = numbers.GetSmallestPositiveNumber();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void GetSmallestPositiveNumberWithHashSet_returns_expected_result(PracticeData data)
    {
        EnsureIsNotTheAssessment();

        // Arrange
        (var numbers, var expected) = data;

        // Act
        var result = numbers.GetSmallestPositiveNumberWithHashSet();

        // Assert
        result.Should().Be(expected);
    }
}