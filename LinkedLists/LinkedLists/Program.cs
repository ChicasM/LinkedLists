using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Node
    {
        public Node next;
        int data;
        //basic constructor
        public Node(int data)
        {
            this.data = data;
        }

    }

    public class LinkedList
    {
        Node head;
        public void append(int data)
        {
            // if no head, it will be created
            if (head  == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
            // keep going checking next until there is no node
            while (current.next != null)
            {
                current = current.next;
            }
            // create new node at end of linked list
            current.next = new Node(data);
        }
    }
}
