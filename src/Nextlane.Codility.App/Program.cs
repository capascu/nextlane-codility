using TestData = Nextlane.Codility.Shared.ValueObjects.AssessmentData; // ToDo
using Nextlane.Codility.Assessment; // ToDo

using Nextlane.Codility.Shared.ValueObjects;

var samples = TestData.GetSamples();

if (AssessmentData.IsTheAssessment && samples is not IEnumerable<AssessmentData>)
{
    Console.WriteLine($"EXECUTE With {nameof(AssessmentData)}!!");
    //Console.ReadKey();
    return;
}

var solution = new Solution();

foreach (var sample in samples)
{
    Console.WriteLine(sample);

    var result = solution.solution(sample.Input);

    Console.WriteLine($"RESULT --> {result}");
    //Console.WriteLine($"RESULT --> [{string.Join(separator: ", ", values: result)}]");
    //Console.WriteLine($"RESULT --> [{string.Join(separator: ", ", values: result.Select(r => r.ToString()))}]");

    Console.WriteLine();
}

//Console.ReadLine();
