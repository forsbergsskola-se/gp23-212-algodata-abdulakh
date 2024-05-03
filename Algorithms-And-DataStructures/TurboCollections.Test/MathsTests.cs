namespace TurboCollections.Test;

public class MathsTests
{
    
    [SetUp]
    public void Setup()
    {
        TurboMaths.GetOddNumberList(12);
       // TurboMaths.GetEvenNumbersList(14);
    }

    [Test]
    public void SayHelloExists()
    {
        //TurboMaths.GetEvenNumbers(12);
        TurboMaths.GetOddNumbers(12);
        Assert.Pass();
    }
}