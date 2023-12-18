using Nextlane.Codility.Practice;

namespace Nextlane.Codility.Tests;

[Trait(name: Traits.Type, value: Traits.PracticeCodility)]
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

    //    // Assert
    //    result.Should().Be(data.Output);
    //}

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Solution_returns_expected_result(PracticeData data)
    {
        EnsureIsNotTheAssessment();

        // Arrange
        (var numbers, var expected) = data;
        var solution = new Solution();


        // Act
        var result = solution.solution(numbers);

        // Assert
        result.Should().Be(expected);
    }

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

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void GetSmallestPositiveNumberWithArraySort_returns_expected_result(PracticeData data)
    {
        EnsureIsNotTheAssessment();

        // Arrange
        (var numbers, var expected) = data;

        // Act
        var result = numbers.GetSmallestPositiveNumberWithArraySort();

        // Assert
        result.Should().Be(expected);
    }
}
