using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.DoblyLinkedList
{
    class DoblyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoblyLinkedListNode<T> Next { get; set; }
        public DoblyLinkedListNode<T> Previous { get; set; }

        public DoblyLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
