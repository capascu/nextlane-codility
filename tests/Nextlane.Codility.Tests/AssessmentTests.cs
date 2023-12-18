using Nextlane.Codility.Assessment;
using Helper = Nextlane.Codility.Shared.Features.Assessment.Helper;

namespace Nextlane.Codility.Tests;

[Trait(name: Traits.Type, value: Traits.AssessmentCodility)]
public class AssessmentTests : TestsBase<AssessmentData>
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Solution_returns_expected_result(AssessmentData data)
    {
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
    public void Get_returns_expected_result(AssessmentData data)
    {
        // Arrange
        (var input, var expected) = data;

        // Act
        var result = input.Get();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void GetDistinct_returns_expected_result(AssessmentData data)
    {
        // Arrange
        (var input, var expected) = data;

        // Act
        var result = input.GetDistinct();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void GetLatest_returns_expected_result(AssessmentData data)
    {
        // Arrange
        (var input, var expected) = data;

        // Act
        var result = Helper.Get(input);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void GetDistinctLatest_returns_expected_result(AssessmentData data)
    {
        // Arrange
        (var numbers, var expected) = data;

        // Act
        var result = Helper.GetDistinct(numbers);

        // Assert
        result.Should().Be(expected);
    }
}
