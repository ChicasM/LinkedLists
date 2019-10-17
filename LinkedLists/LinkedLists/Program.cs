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
        public int data;
        //basic constructor
        public Node(int data)
        {
            this.data = data;
        }

    }

    public class LinkedList
    {
        Node head;
        public void addNode(int data)
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

        public void addBefore(int data)
        {
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void deletewithValue(int data)
        {
            if (head == null)
            {
                return;
            }
            if (head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }

            
        }


    }
}
