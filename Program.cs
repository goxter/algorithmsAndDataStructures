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
            ASP.LinkedList.LinkedList<int> lista = new ASP.LinkedList.LinkedList<int>();
            lista.insertAtStart(2);
            lista.insertAtStart(1);
            lista.insertAtEnd(3);
            lista.insertAtEnd(4);
            //Console.WriteLine(lista.insertAfter(lista.Head, 2));
            //Console.WriteLine(lista.insertBefore(lista.Tail, 3));
            
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
        }
    }
}
