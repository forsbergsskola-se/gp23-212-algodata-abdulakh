namespace TurboCollections.Test;

[TestFixture]
public class BubbleSortTest
{
    [Test]
    public void BubbleSortTesting()
    {
        int[] unsortedNumbers = { 5, 1, 12, -5, 16 };
        int[] sortedNumbers = { -5, 1, 5, 12, 16 };
        
        TurboBubble.BubbleSort(unsortedNumbers);
        
        Assert.That(unsortedNumbers, Is.EqualTo(sortedNumbers));
    }
}