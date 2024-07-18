namespace TurboCollections.Test;

[TestFixture]
public class BinarySearchTreeTest
{
    private TurboBinaryTree<int> tree;

    [SetUp]
    public void Setup()
    {
        tree = new TurboBinaryTree<int>(10);
    }
    
    [Test]
    public void GetValueTest()
    {
        tree.SetValue(0, 10);

        int value = tree.GetValue(0);
        
        Assert.That(value, Is.EqualTo(10));
    }

    [Test]
    public void SetValueTest()
    {
        tree.SetValue(1, 20);

        int value = tree.GetValue(1);
        
        Assert.That(value, Is.EqualTo(20));
    }

    [Test]
    public void GetLeftChildTest()
    {
        int leftChild = tree.GetLeftChild(0);
        
        Assert.That(1, Is.EqualTo(leftChild));
    }

    [Test]
    public void GetRightChildTest()
    {
        int rightChild = tree.GetRightChild(0);
        
        Assert.That(2, Is.EqualTo(rightChild));
    }
}