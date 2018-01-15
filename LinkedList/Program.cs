using System;

namespace LinkedList
{
    class LinkedList
    {
        public class Node
        {
            public Object Value { get; set; }
            public Node Next { get; set; }
            public Node(Object data)
            {
                Value = data;
                Next = null;
            }
        }
        public Node Head;

        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.Head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node fourth = new Node(4);
            lList.Head.Next = second;
            second.Next = third;
            third.Next = fourth;
            lList.PrintNodes(lList.Head);

            lList.AddLast(6,lList.Head);
            lList.PrintNodes(lList.Head);
        }
        public void PrintNodes(Node node)
        {
            while (node.Next != null)
            {
                Console.WriteLine(node.Value.ToString());
                node = node.Next;
            }
            Console.ReadKey();

        }
        public void AddLast(object valueToBeAdded, Node node)
        {
            Node currentNode = new Node(valueToBeAdded);
            if (node.Value == null)
            {
                node.Next = currentNode;
            }
            else
            {
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = currentNode;
            }
        }
        public void AddFirst(object valueToBeAdded, Node node)
        {
            if (true)
            {

            }
        }
    }
}
