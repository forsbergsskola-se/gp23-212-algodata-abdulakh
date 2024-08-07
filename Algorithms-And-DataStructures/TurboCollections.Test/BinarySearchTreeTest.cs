using NUnit.Framework;

namespace TurboCollections.Tests
{
    [TestFixture]
    public class BinarySearchTreeTests
    {
        private BinarySearchTree _bst;

        [SetUp]
        public void Setup()
        {
            _bst = new BinarySearchTree();
        }

        [Test]
        public void Insert_RootNode_ShouldSetRoot()
        {
            int value = 10;
            _bst.Insert(value);

            Assert.IsNotNull(_bst.Root);
            Assert.AreEqual(value, _bst.Root.Data);
        }

        [Test]
        public void Insert_LeftChild_ShouldSetLeftChild()
        {
            int rootValue = 10;
            int leftChildValue = 5;
            _bst.Insert(rootValue);
            _bst.Insert(leftChildValue);

            Assert.IsNotNull(_bst.Root.Left);
            Assert.AreEqual(leftChildValue, _bst.Root.Left.Data);
        }

        [Test]
        public void Insert_RightChild_ShouldSetRightChild()
        {
            int rootValue = 10;
            int rightChildValue = 15;
            _bst.Insert(rootValue);
            _bst.Insert(rightChildValue);

            Assert.IsNotNull(_bst.Root.Right);
            Assert.AreEqual(rightChildValue, _bst.Root.Right.Data);
        }

        [Test]
        public void Search_NodeExists_ShouldReturnNode()
        {
            int value = 10;
            _bst.Insert(value);

            Node result = _bst.Search(_bst.Root, value);

            Assert.IsNotNull(result);
            Assert.AreEqual(value, result.Data);
        }

        [Test]
        public void Search_NodeDoesNotExist_ShouldReturnNull()
        {
            int value = 10;
            _bst.Insert(value);

            Node result = _bst.Search(_bst.Root, 20);

            Assert.IsNull(result);
        }

        [Test]
        public void Delete_NodeWithNoChildren_ShouldRemoveNode()
        {
            _bst.Insert(10);
            _bst.Insert(5);
            _bst.Insert(15);

            _bst.Delete(5);

            Assert.IsNull(_bst.Search(_bst.Root, 5));
            Assert.IsNotNull(_bst.Search(_bst.Root, 10));
            Assert.IsNotNull(_bst.Search(_bst.Root, 15));
        }

        [Test]
        public void Delete_NodeWithOneChild_ShouldReplaceNodeWithChild()
        {
            _bst.Insert(10);
            _bst.Insert(5);
            _bst.Insert(15);
            _bst.Insert(3);

            _bst.Delete(5);

            Assert.IsNull(_bst.Search(_bst.Root, 5));
            Assert.IsNotNull(_bst.Search(_bst.Root, 3));
            Assert.IsNotNull(_bst.Search(_bst.Root, 10));
            Assert.IsNotNull(_bst.Search(_bst.Root, 15));
        }

        [Test]
        public void Delete_NodeWithTwoChildren_ShouldReplaceNodeWithInOrderPredecessor()
        {
            _bst.Insert(10);
            _bst.Insert(5);
            _bst.Insert(15);
            _bst.Insert(3);
            _bst.Insert(7);

            _bst.Delete(5);

            Assert.IsNull(_bst.Search(_bst.Root, 5));
            Assert.IsNotNull(_bst.Search(_bst.Root, 3));
            Assert.IsNotNull(_bst.Search(_bst.Root, 7));
            Assert.IsNotNull(_bst.Search(_bst.Root, 10));
            Assert.IsNotNull(_bst.Search(_bst.Root, 15));
        }
    }
}
