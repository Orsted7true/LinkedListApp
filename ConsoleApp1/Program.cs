using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinkedListLibrary;

class Program
{
    static void Main()
    {
        var list = new LinkedList();
        list.AddToEnd(1.1f);
        list.AddToEnd(2.2f);
        list.AddToEnd(3.3f);
        list.AddToEnd(-3.3f);

        list.AddAfterSecond(9.9f);


        list.AddAfterSecond(11.1f);
        PrintList(list);

        bool isDeleted = false;
        int input = 0;
        while (!isDeleted)
        {
            Console.WriteLine("Choose the number of element to delete");
            input = int.Parse(Console.ReadLine()) - 1;
            isDeleted = list.deleteElement(input);
        }
        

        Console.WriteLine($"\nAfter deleting element {input+1}:");
        PrintList(list);

        float? result = list.FirstNegativeEl();

        if (result.HasValue)
            Console.WriteLine("\nFirst negative element: " + result.Value);
        else
            Console.WriteLine("\nNo negative elements found.");


        float greaterSum = list.SumOfElementsGreaterThanMedian();


        Console.WriteLine("\nThe sum of elements greater than median:" + greaterSum);


        LinkedList newList = list.PostitiveElementsList();

        Console.WriteLine("\nThe new list of postive values:");
        PrintList(newList);

        list.deleteAllNegativeElements();

        Console.WriteLine("\nThe old list of postive values:");
        PrintList(list);
    }
    static void PrintList(LinkedList list)
    {
        for (int i = 0; i < list.Size; i++)
        {
            if (i > 0)
                Console.Write(" -> ");
            Console.Write(list[i]);
        }
        Console.WriteLine();
    }

}
