namespace Nextlane.Codility.Shared.Features.Practice; // Do not copy!!

//public /*internal*/ sealed class Solution
//{
//    public int solution(int[] A) =>
//        NumbersHelper.GetSmallestPositiveNumber(A);
//}

public /*file*/ static class NumbersHelper
{
    public /*internal*/ static int GetSmallestPositiveNumber(this IEnumerable<int> numbers)
    {
        const int minNumber = 1;
        const int maxNumber = 100_000;

        int[] positiveNumbers = numbers.Where(n => n is >= minNumber and <= maxNumber)
            .Distinct()
            .OrderBy(n => n)
            .ToArray();

        for (var index = 0; index < positiveNumbers.Length; index++)
        {
            int number = positiveNumbers[index];
            if (number != (index + 1))
            {
                return (index + 1);
            }
        }

        return positiveNumbers.Length + 1;
    }

    public /*internal*/ static int GetSmallestPositiveNumberWithHashSet(this IEnumerable<int> numbers)
    {
        const int minNumber = 1;
        const int maxNumber = 100_000;

        var positiveNumbers = numbers.Where(n => n is >= minNumber and <= maxNumber)
            //.Distinct()
            .ToHashSet();

        for (int number = minNumber; number <= maxNumber; number++)
        {
            if (!positiveNumbers.Contains(number))
            {
                return number;
            }
        }

        return positiveNumbers.Count + 1;
    }
}
