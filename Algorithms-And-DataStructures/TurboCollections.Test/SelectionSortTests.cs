namespace TurboCollections.Test
{
    [TestFixture]
    public class TurboSortTests
    {
        [Test]
        public void SelectionSort_lowestToHighest()
        {
            List<int> numbers = new List<int> { 5, 4, 2, 3, 1 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            
            TurboSort.SelectionSort(numbers);

            Assert.That(numbers, Is.EqualTo(expected));
        }
    }
}