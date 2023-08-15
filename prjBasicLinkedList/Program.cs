using System.Text;
using System.Xml.Linq;

namespace prjBasicLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blob blobGen= new Blob();
            blobGen.Add(6);
            blobGen.Add(7);
            blobGen.Add(8);
            blobGen.Add(9);
            blobGen.Add(10);
            blobGen.Add(11);
            blobGen.Add(12);

            Node head = blobGen.Head;


            //Node n = new Node(6);
            //Node na = new Node(7);
            //Node nb = new Node(8);
            //n.next = na;
            //na.previous = n;
            //na.next = nb;
            //nb.previous = na;
            Console.WriteLine("Size of the list is {0}"
                ,countNode(head));
        }
        public static int countNode(Node Head)
        {
            int count = 1;
            Node current = Head;
            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }
        public static Node GetLast(Node Head)
        {
            Node last = Head;
            while(last.next != null)
            {
                last = last.next;
            }
            return last;
        }
        public static Node GetFirst(Node Middle)
        {
            Node first = Middle;
            while(first.previous != null)
            {
                first = first.previous;
            }
            return first;
        }
        public static Node FindNode(int Value,Node Head)
        {
            Node Current = Head;
            while(Current.next != null)
            {
                if(Current.value == Value)
                {
                    return Current;
                }
            }
            return null;
        }
        public static Node AddNode(Node Add,Node Current)
        {
            Add.previous = Current;
            Add.next = Current.next;
            Current.next = Add;
            return Current;
        }
        //Print out whole list 
        public static void PrintAll(Node Head)
        {
            Node currrent = GetFirst(Head);
            Console.Write("Node Print out: ");
            while (currrent != null)
            {
                Console.Write(currrent.value+" ");
                currrent = currrent.next;
            }
            Console.WriteLine();
        }
        //Find inside the list and indicate that spot and show whole list
        public static void FindNodePrintAll(Node current)
        {
            if (current == null)
            {
                Console.WriteLine("No {0} not found in the list",current.value);
                return;
            }


            StringBuilder result = new StringBuilder("(" + current.value + ")");
            Node nodeP = current.previous;
            while (nodeP != null)
            {
                result.Insert(0, nodeP.value + " ");
                nodeP = nodeP.previous;
            }

            current = current.next;
            while (current != null)
            {
                result.Append(" " + current.value);
                current = current.next;
            }
            Console.WriteLine(result);
            Console.WriteLine();

        }

        //Create a call to create your nodes in

    }
}