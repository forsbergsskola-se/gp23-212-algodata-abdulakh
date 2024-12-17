using NUnit.Framework.Internal;

namespace TurboCollections.Test;

[TestFixture]
public class LinearSearchTest
{
    [Test]
    public void TestLinearSearch()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        var target = 6;

        var result = TurboSearch.LinearSearch(numbers, target);
        
        Assert.That(result, Is.EqualTo(5));
    }
}