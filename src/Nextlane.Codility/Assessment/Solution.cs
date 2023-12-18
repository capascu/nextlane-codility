namespace Nextlane.Codility.Assessment // ToDo: do not copy!!
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public /* sealed */ sealed class Solution : IDisposable
    {
        public int solution(int[] A) =>
            A.Get();

        public void Dispose()
        {
        }
    }

    public /*internal*/ static class Helper
    {
        public /*internal*/ static int Get(this IEnumerable<int> input)
        {
            var values= input
                .GroupBy(i => i)
                .ToDictionary(g => new KeyValuePair<int, int>(g.Key, g.Count()))
                .Keys
                .Count;
                
            return values;
        }

        public /*internal*/ static int GetDistinct(this IEnumerable<int> input) =>
            input
                .Distinct()
                .Count();
    }
}
