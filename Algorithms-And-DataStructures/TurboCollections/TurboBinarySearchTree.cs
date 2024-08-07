namespace TurboCollections
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node Root;

        public void Insert(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return;
            }

            Node current = Root;
            Node parent = null;

            while (current != null)
            {
                parent = current;
                if (data < current.Data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            if (data < parent.Data)
            {
                parent.Left = new Node(data);
            }
            else
            {
                parent.Right = new Node(data);
            }
        }

        public Node Search(Node root, int value)
        {
            Node currentNode = root;

            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    return currentNode;
                }
                if (value > currentNode.Data)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    currentNode = currentNode.Left;
                }
            }

            return null;
        }

        public void Delete(int data)
        {
            Root = DeleteRec(Root, data);
        }

        private Node DeleteRec(Node root, int data)
        {
            if (root == null)
            {
                return root;
            }

            if (data < root.Data)
            {
                root.Left = DeleteRec(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = DeleteRec(root.Right, data);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                root.Data = MaxValue(root.Left);
                root.Left = DeleteRec(root.Left, root.Data);
            }

            return root;
        }

        private int MaxValue(Node node)
        {
            int maxv = node.Data;
            while (node.Right != null)
            {
                maxv = node.Right.Data;
                node = node.Right;
            }

            return maxv;
        }
    }
}
