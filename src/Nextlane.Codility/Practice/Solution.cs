namespace Nextlane.Codility.Practice // Do not copy!!
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // internal sealed class Solution
    public sealed class Solution: IDisposable
    {
        public int solution(int[] A) =>
            A.GetSmallestPositiveNumber();

        public void Dispose()
        {
        }
    }

    public /*internal*/ static class NumbersHelper
    {
        public /*internal*/ static int GetSmallestPositiveNumber(this IEnumerable<int> numbers)
        {
            const int minNumber = 1;
            const int maxNumber = 100000; // C# 7.0+ --> 100_000

            int[] positiveNumbers = numbers.Where(n => n >= minNumber && n <= maxNumber)
                .Distinct()
                .OrderBy(n => n)
                .ToArray();

            for (var index = 0; index < positiveNumbers.Length; index++)
            {
                int number = positiveNumbers[index];
                if (number != (index + 1))
                {
                    return index + 1;
                }
            }

            return positiveNumbers.Length + 1;
        }

        public /*internal*/ static int GetSmallestPositiveNumberWithHashSet(this IEnumerable<int> numbers)
        {
            const int minNumber = 1;
            const int maxNumber = 100000; // C# 7.0+ --> 100_000

            var positiveNumbers = numbers.Where(n => n >= minNumber && n <= maxNumber)
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

        public /*internal*/ static int GetSmallestPositiveNumberWithArraySort(this IEnumerable<int> numbers)
        {
            const int minNumber = 1;
            const int maxNumber = 100000; // C# 7.0+ --> 100_000

            int[] positiveNumbers = numbers.Where(n => n >= minNumber && n <= maxNumber)
                .Distinct()
                .OrderBy(n => n)
                .ToArray();

            Array.Sort(positiveNumbers);

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
    }
}
