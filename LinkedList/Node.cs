using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        /*
         * Constructor:
         * [] public Node (object data, Node next) - to easily initialize from where the object is created.
         * 
         * Private fields:
         * [] Object _data - to store the actual data
         * [] Node _next - to store the reference of the next linked node.
         * 
         * Public properties:
         * [] Data - getter/setter for _data
         * [] Next - getter/setter for _next
         */

        object _data;
        Node _next;

        public Node(object data, Node next)
        {
            _data = data;
            _next = next;
        }

        public object Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
}
