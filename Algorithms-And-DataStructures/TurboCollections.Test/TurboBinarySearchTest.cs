namespace TurboCollections.Test;

public abstract class TurboBinarySearchTest
{
    [TestFixture]
    public class BinarySearchTest
    {
        [Test]
        public void Test()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var target = 6;

            var result = TurboSearch.BinarySearch(numbers, target);
        
            Assert.That(result, Is.EqualTo(5));
        }
    }
    
}