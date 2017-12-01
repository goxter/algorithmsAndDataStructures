using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.DoblyLinkedList
{
    class DoblyLinkedList<T>
    {
        public DoblyLinkedListNode<T> Head { get; private set; }
        public DoblyLinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public DoblyLinkedList()
        {
            this.Count = 0;
            this.Head = null;
            this.Tail = null;
        }

        public void insertAtStart(T insert)
        {
            DoblyLinkedListNode<T> newNode = new DoblyLinkedListNode<T>(insert);
            if(this.Count == 0)
            {
                this.Tail = newNode;
            }
            else
            {
                newNode.Next = this.Head;
                this.Head.Previous = newNode;                
            }
            this.Head = newNode;
            this.Count++;
        }

        public void insertAtEnd (T insert)
        {
            DoblyLinkedListNode<T> newNode = new DoblyLinkedListNode<T>(insert);
            if(this.Count == 0)
            {
                this.Head = newNode;   
            }
            else
            {
                newNode.Previous = this.Tail;
                this.Tail.Next = newNode;
            }
            this.Tail = newNode;
            this.Count++;
        }

        public void removeFromStart()
        {
            if (this.Count == 0) return;
            if (this.Count == 1)
            {
                this.Head = null;
                this.Tail = null;
                return;
            }

            this.Head.Next.Previous = null;
            this.Head = this.Head.Next;
            this.Count--;
        }

        public void removeFromEnd()
        {
            if (this.Count == 0) return;
            if (this.Count == 1)
            {
                this.Head = null;
                this.Tail = null;
                return;
            }

            this.Tail.Previous.Next = null;
            this.Tail = this.Tail.Previous;
            this.Count--;
        }

        public DoblyLinkedList<T> concatenate(DoblyLinkedList<T> list)
        {
            if (this.Count == 0 && list.Count == 0) return null;
            if (this.Count == 0) return list;
            if (list.Count == 0) return this;

            DoblyLinkedList<T> newList = new DoblyLinkedList<T>();
            newList.Head = this.Head;
            this.Tail.Next = list.Head;
            list.Head.Previous = this.Tail;
            newList.Tail = list.Tail;
            newList.Count = this.Count + list.Count;
            return newList;
        }

        public DoblyLinkedListNode<T> searchList(T search)
        {
            DoblyLinkedListNode<T> node = new DoblyLinkedListNode<T>(search);
            DoblyLinkedListNode<T> currentNode = this.Head;
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
    }
}
