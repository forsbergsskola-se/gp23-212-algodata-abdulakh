namespace TurboCollections
{
    public class TurboLinkedStack<T>
    {
        public class Node
        {
            public T Value;
            public Node Previous;
        }

        Node LastNode;

        public void Push(T level)
        {
            Node newNode = new Node();
            newNode.Value = level; 
            if (LastNode == null) 
            {
                LastNode = newNode; 
            }
            else
            {
                newNode.Previous = LastNode; 
                LastNode = newNode; 
            }
        }

        public T Peek()
        {
            return LastNode.Value;
        }

        public T Pop()
        {
            T savedValue = LastNode.Value;
            LastNode = LastNode.Previous;
            return savedValue;
        }

        public void Clear()
        {
            LastNode = null;
        }

        public int Count
        {
            get
            {
                int count = 0;
                Node current = LastNode;
                while (current != null)
                {
                    count++;
                    current = current.Previous;
                }
                return count;
            }
        }
        
    }
}