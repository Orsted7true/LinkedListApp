
using System;

namespace LinkedListLibrary
{
    public class Node
    {
        public float Data { get; set; }
        public Node? Next { get; set; }

        public Node(float data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node? head;
        private int number;
      
        public void AddToEnd(float value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            number++;
        }

        public void AddAfterSecond(float value)
        {
            if (head == null || head.Next == null)
            {
                Console.WriteLine("The list has less than two elements");
                return;
            }

            Node newNode = new Node(value);
            Node second = head.Next;

            newNode.Next = second.Next;
            second.Next = newNode;
            number++;
        }
        public int Size
        {
            get { return number; }
        }


        public float this[int index]
        {
            get
            {
                if (index < 0 || index >= number)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                Node current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                if (index < 0 || index >= number)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                Node current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Data = value;
            }
        }



        public bool deleteElement(int elNum)
        {
            if (elNum >= 0 && elNum < Size)
            {
                if (elNum == 0)
                {
                    head = head.Next;
                }
                else
                {
                    Node current = head;
                    Node previous = null;
                    for (int i = 0; i < elNum; i++)
                    {
                        previous = current;
                        current = current.Next;
                    }
                    previous.Next = current.Next;

                }
                number--;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid index");
                return false;
            }
        }

        public float? FirstNegativeEl()
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data < 0)
                {
                    return current.Data; 
                }
                current = current.Next;
            }
            return null; 
        }


        public float SumOfElementsGreaterThanMedian()
        {

            Node current = head;
            float sumOfAll = 0;
            while (current != null)
            {

                sumOfAll += current.Data;
                current = current.Next;
            }

            float Median = sumOfAll / number;


            float SumOfElemenetsGreaterThanMedian = 0;
            current = head;
            while(current != null)
            {
                if(current.Data > Median)
                {
                    SumOfElemenetsGreaterThanMedian += current.Data;
                }
                current = current.Next;
            }

            return SumOfElemenetsGreaterThanMedian;
        }

        public LinkedList PostitiveElementsList()
        {
            LinkedList newList = new LinkedList();
            Node current = head;
            while (current != null)
            {
                if (current.Data > 0)
                    newList.AddToEnd(current.Data);
                current = current.Next;
            }

            return newList;

        }

        public void deleteAllNegativeElements()
        {
            int i = 0;
            while (i < Size)
            {
                if (this[i] < 0)
                {
                    deleteElement(i); 
                }
                else
                {
                    i++; 
                }
            }
        }


    }
}
