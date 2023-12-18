namespace Nextlane.Codility.Shared.Abstractions;

public interface ITestable<out TSelf>
    where TSelf : ITestable<TSelf>
{
    public static abstract TSelf GetPerformanceData();

    //public static virtual IEnumerable<object[]> GetTestData() =>
    //    TSelf.GetSamples()
    //        .Select(d => new object[] { d });

    public static abstract IEnumerable<TSelf> GetSamples();
}
