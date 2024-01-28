using System;
using System.Collections.Generic;
using static DoublyLinkedList.DoublyLinkedList;

namespace DoublyLinkedList
{
  public class StartUp
    {
        static void Main(string[] args)
        {

            List<DoublyLinkedList> linkedList = new List<DoublyLinkedList>();
            DoublyLinkedList doubly = new DoublyLinkedList();
            doubly.AddFirst(1);
            doubly.AddFirst(2);
            doubly.AddFirst(3);

            doubly.AddLast(11);
            doubly.RemoveLast();
            doubly.RemoveFirst();

            doubly.ForEach(n => Console.WriteLine(n));

        }
    }
}
