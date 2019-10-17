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
            // new head will link to old head
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void deleteNode(int data)
        {
            if (head == null)
            {
                return;
            }
            // if head has data, set next node to new head
            if (head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;

            while (current.next != null)
            {
                // iff data is found that you want to cut do this
                if (current.next.data == data)
                {
                    // set the new next node to the node after one you want to cut
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }

            
        }


    }
}
