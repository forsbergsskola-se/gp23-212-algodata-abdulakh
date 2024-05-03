namespace TurboCollections.Test
{
    using NUnit.Framework;
    using TurboCollections;

    public class TurboLinkedStackTests
    {
        private TurboLinkedStack<int> stack;

        [SetUp]
        public void Setup()
        {
            stack = new TurboLinkedStack<int>();
        }

        [Test]
        public void PushPopTest()
        {
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);

            Assert.AreEqual(7, stack.Peek()); 
            Assert.AreEqual(7, stack.Pop());
    
            Assert.AreEqual(5, stack.Peek()); 
            Assert.AreEqual(5, stack.Pop());
    
            Assert.AreEqual(3, stack.Peek());
            Assert.AreEqual(3, stack.Pop());
            
        }
        
        [Test]
        public void ClearTest()
        {
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);

            stack.Clear();

        }
        
        [Test]
        public void CountTest()
        {
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);

            Assert.AreEqual(3, stack.Count);
            stack.Pop();

            Assert.AreEqual(2, stack.Count);
            stack.Clear();

            Assert.AreEqual(0, stack.Count);
        }
    }
}