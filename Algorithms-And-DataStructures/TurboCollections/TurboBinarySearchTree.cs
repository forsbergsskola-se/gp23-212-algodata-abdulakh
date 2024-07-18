using Microsoft.VisualBasic.FileIO;

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

        public BinarySearchTree()
        {
            Root = null;
        }

        public Node Search(Node root, int data)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Data == data)
            {
                return root;
            }
            else
            {
                Node current = root;

                while (current !=null)
                {
                    if (data > current.Data)
                    {
                        
                    }
                }
            }
            
            return null;
        }

        public Node Insert()
        {
            return null;
        }
    }
}