//using System;

//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProblemSqolvingPractice
//{
//    public  class Node 
//    {
//        public int data {  get; set; }
//        public Node ? Next { get; set; }
//    }
//    public  class MyLinkedList
//    {

//         public  Node? Head { get; set; }


//        public  void AddFirst( int data)
//        {
//            if (Head == null)
//            {
//                Head = new Node();
//                Head.data = data;
//            }
//            else
//            {
//               Node newNode = new Node();
//                newNode.data = data;
//                newNode.Next = Head;
//                Head = newNode;
//            }

//        }
//        public void AddLast(int data)
//        {
//            if(Head==null)
//            {
//                Head = new Node();
//                Head.data = data;
//            }
//            else
//            {

//                Node current = Head;
//                while (current.Next != null)
//                {
//                    current = current.Next;
//                }
//                current.Next = new Node();
//                current.Next.data = data;

//            }
//            }
//        public void Remvoe()
//        {
//            if (Head == null)
//            { return; }
//            Head = new Node();
//            Head.data = Head.Next.data;
//            Head.Next = null;
//        }


//        public void Print()
//        {
//            Node current = Head;
//            while (current != null)
//            {
//                Console.WriteLine(current.data);
//                current = current.Next;
//            }
//        }
//    }
//}
using System;

public class Node
{
    public int data;
    public Node? Next ;

    public Node()
    {
      
    }
}

public class LinkedList
{
    public Node? Head;

    public void AddFirst(int data)
    {
        if (Head == null)
        {
            Head = new Node();
            Head.data = data;
        }
        else
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.Next = Head;
            Head = newNode;
        }

    }
  

    // Method to reverse the linked list
    public void Reverse()
    {
        Node prev = null;
        Node current = Head;
        Node nextNode = null;

        while (current != null)
        {
            nextNode = current.Next; // Store next node
            current.Next = prev;     // Reverse the link
            prev = current;          // Move prev to current node
            current = nextNode;      // Move current to next node
        }

        Head = prev; // Update the head to the new first element
    }

    // Method to print the linked list
    public void PrintList()
    {
        Node temp = Head;
        while (temp != null)
        {
            Console.Write(temp.data  + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}