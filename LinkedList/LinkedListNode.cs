using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.LinkedList
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }

        /*
        public bool isEqual(LinkedListNode<T> node)
        {
            if(EqualityComparer<T>.Default.Equals(this.Value, node.Value) && Object.ReferenceEquals(this.Next, node.Next))
            {
                return true;
            }
            return false;
        }*/
    }
}
