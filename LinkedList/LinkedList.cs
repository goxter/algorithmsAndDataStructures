using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.LinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            this.Count = 0;
            this.Head = null;
            this.Tail = null;
        }

        public void insertAtStart(T insert)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>(insert);
            if(this.Count == 0)
            {
                this.Tail = temp;
            }
            else
            {
                temp.Next = this.Head;
            }
            this.Head = temp;
            this.Count++;
        }

        public void insertAtEnd(T insert)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>(insert);
            if(this.Count == 0)
            {
                this.Head = temp;
            }
            else
            {
                this.Tail.Next = temp;                
            }
            this.Tail = temp;
            this.Count++;
        }

        public void removeFromStart()
        {
            if (this.Count == 0) return;
            if (this.Count == 1)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                this.Head = this.Head.Next;
            }
            this.Count--;
        }

        public void removeFromEnd()
        {
            if (this.Count == 0) return;
            if (this.Count == 1)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                LinkedListNode<T> temp = this.Head;
                while (temp.Next != this.Tail)
                {
                    temp = temp.Next;
                }
                this.Tail = temp;
                this.Tail.Next = null;
            }
            this.Count--;
        }

        public LinkedListNode<T> searchList(T search)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(search);
            LinkedListNode<T> currentNode = this.Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(node.Value))
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }

        public LinkedList<T> concatenate(LinkedList<T> list)
        {
            if (this.Count == 0 && list.Count == 0) return null;
            if (this.Count == 0) return list;
            if (list.Count == 0) return this;
            LinkedList<T> newList = new LinkedList<T>();
            newList.Head = this.Head;
            this.Tail.Next = list.Head;
            newList.Tail = list.Tail;
            newList.Count = this.Count + list.Count;
            return newList;
        }

        public void invert()
        {
            if (this.Count == 0) return;
            LinkedListNode<T> temp1 = this.Head;
            LinkedListNode<T> temp2 = null;
            LinkedListNode<T> temp3 = null;
            while (temp1 != null)
            {
                temp3 = temp2;
                temp2 = temp1;
                temp1 = temp1.Next;
                temp2.Next = temp3;                
            }
            Head = temp2;
        }

        /*
         * Nema poente za ovim operacijama ukoliko lista moze da sadrzi iste elemente i nije uredjena
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
        
        */
    }
}
