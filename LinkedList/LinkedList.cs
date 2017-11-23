using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.LinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void insertAtStart(T insert)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>(insert);
            if (Head == null)
            {
                Head = temp;
                Tail = temp;
            }
            else
            {
                temp.Next = Head.Next;
                Head.Next = temp;
            }            
        }

        public void insertAtEnd(T insert)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>(insert);
            if(Head == null)
            {
                Head = temp;
                Tail = temp;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
            }
        }

        public bool insertAfter(LinkedListNode<T> after, T insert)
        {
            if(!this.checkIfExistsInList(after))
            {
                return false;
            }

            LinkedListNode<T> temp = new LinkedListNode<T>(insert);
            temp.Next = after.Next;
            after.Next = temp;
            return true;
        }

        public bool insertBefore(LinkedListNode<T> before, T insert)
        {
            if(!this.checkIfExistsInList(before))
            {
                return false;
            }

            LinkedListNode<T> temp = new LinkedListNode<T>(insert);
            temp.Next = before.Next;
            temp.Value = before.Value;
            before.Value = insert;
            return true;
        }

        public bool checkIfExistsInList(LinkedListNode<T> node)
        {
            LinkedListNode<T> currentNode = this.Head;
            while (currentNode!=null)
            {
                if(currentNode.isEqual(node))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
    }
}
