using Nextlane.Codility.Shared.Features.Assessment;

namespace Nextlane.Codility.Tests.Features;

[Trait(name: Traits.Type, value: Traits.AssessmentLatest)]
public sealed class AssessmentTests : TestsBase<AssessmentData>
{

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
}
