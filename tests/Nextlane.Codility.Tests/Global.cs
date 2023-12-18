global using FluentAssertions;
global using Nextlane.Codility.Shared.ValueObjects;
global using Nextlane.Codility.Tests.Abstractions;
global using Xunit;

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(category: "Naming", checkId: "CA1707:Identifiers should not contain underscores", Justification = "Test methods require underscores for readability.")]

namespace Nextlane.Codility.Tests;

internal static class Traits
{
    internal const string Type = nameof(Type);

    internal const string AssessmentLatest = nameof(AssessmentLatest);
    internal const string AssessmentCodility = nameof(AssessmentCodility);
    internal const string PracticeLatest = nameof(PracticeLatest);
    internal const string PracticeCodility = nameof(PracticeCodility);
}
