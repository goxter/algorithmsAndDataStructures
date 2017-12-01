using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.LinkedList;

namespace ASP
{
    class Program
    {
        static void Main(string[] args)
        {
            ASP.DoblyLinkedList.DoblyLinkedList<int> lista1 = new ASP.DoblyLinkedList.DoblyLinkedList<int>();
            //ASP.LinkedList.LinkedList<int> lista1 = new ASP.LinkedList.LinkedList<int>();
            lista1.insertAtStart(2);
            lista1.insertAtStart(1);
            lista1.insertAtEnd(3);
            lista1.insertAtEnd(4);

            ASP.DoblyLinkedList.DoblyLinkedList<int> lista2 = new ASP.DoblyLinkedList.DoblyLinkedList<int>();
            //ASP.LinkedList.LinkedList<int> lista2 = new ASP.LinkedList.LinkedList<int>();
            lista2.insertAtStart(6);
            lista2.insertAtStart(5);
            lista2.insertAtEnd(7);
            lista2.insertAtEnd(8);

            ASP.DoblyLinkedList.DoblyLinkedList<int> lista;
            lista = lista1.concatenate(lista2);
            //lista.invert();
            lista.removeFromEnd();
            lista.removeFromStart();
            ASP.DoblyLinkedList.DoblyLinkedListNode<int> temp = lista.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
            Console.WriteLine("INSERT END");
            //Console.WriteLine(lista.insertAfter(lista.Head, 2));
            //Console.WriteLine(lista.insertBefore(lista.Tail, 3));
            /*
            ASP.LinkedList.LinkedListNode<int> temp = lista.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
            Console.WriteLine("INSERT END");
            ASP.LinkedList.LinkedListNode<int> pretraga = lista.searchList(2);
            if (pretraga != null)
            {
                Console.WriteLine("Pronadjen element: " + pretraga.Value);
            }
            else
            {
                Console.WriteLine("Element ne postoji");
            }
            lista.removeFromEnd();
            lista.removeFromStart();
            lista.removeFromEnd();
            temp = lista.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
            pretraga = lista.searchList(2);
            if (pretraga != null)
            {
                Console.WriteLine("Pronadjen element: " + pretraga.Value);
            }
            else
            {
                Console.WriteLine("Element ne postoji");
            }

            pretraga = lista.searchList(3);
            if (pretraga != null)
            {
                Console.WriteLine("Pronadjen element: " + pretraga.Value);
            }
            else
            {
                Console.WriteLine("Element ne postoji");
            }
            Console.WriteLine("END");
            */
        }
    }
}
