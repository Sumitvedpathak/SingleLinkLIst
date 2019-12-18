using System;

namespace SingleLinkLIst
{
    public class Node
    {
        public Node next;
        public int data;
    }

    public class SingleLinkList
    {
        private Node root;

        public Node Root
        {
            get
            {
                if (root == null)
                    return null;
                return root;
            }
        }

        public int Length
        {
            get
            {
                int cnt = 1;
                Node curr = root;
                while (curr.next != null)
                {
                    curr = curr.next;
                    cnt++;
                }
                return cnt;
            }
        }

        public Node Last
        {
            get
            {
                if (root == null)
                    return null;
                Node curr = root;
                while (curr.next != null)
                    curr = curr.next;
                return curr;
            }
        }

        public void Add(int data)
        {
            Node newNode = new Node { data = data, next = null };
            Node curr = Last;
            if (curr == null)
                root = new Node { data = data, next = null };
            else
                curr.next = newNode;
        }

        public void Update(int index, int data)
        {
            int counter = 1;
            bool found = false;
            Node curr = root;
            while (curr.next != null)
            {
                if (counter == index)
                {
                    curr.data = data;
                    found = true;
                    break;
                }
                curr = curr.next;
                counter++;
            }
            if (counter == index)
            {
                curr.data = data;
                found = true;
            }
            if (!found)
                Console.WriteLine($"Index {data} not found in Single Link List.");
        }

        public void Delete(int data)
        {
            bool found = false;
            if (root.data == data)
            {
                root = root.next;
                found = true;
            }
            else
            {
                Node prev, curr;
                prev = curr = root;
                while (curr.next != null)
                {
                    if (curr.data == data)
                    {
                        prev.next = curr.next;
                        found = true;
                    }
                    prev = curr;
                    curr = curr.next;
                }
                if (curr.data == data)
                {
                    prev.next = null;
                    found = true;
                }

            }
            if (found)
                Console.WriteLine($"Node {data} has been deleted.");
            else
                Console.WriteLine($"Node {data} not found.");
        }

        public bool Search(int data)
        {
            Node curr = root;
            if (curr == null)
                return false;
            while (curr.next != null)
            {
                if (curr.data == data)
                    return true;
                curr = curr.next;
            }
            if (curr.data == data)
                return true;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList list = new SingleLinkList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            int length = list.Length;
            Node root = list.Root;
            Node last = list.Last;
            bool yest = list.Search(4);
            //list.Delete(7);
        }
    }
}
