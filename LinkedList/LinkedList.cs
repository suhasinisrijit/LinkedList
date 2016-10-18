using System;

namespace LinkedList
{
    class LinkedList
    {
        /*
         * Constructor:
         * [] public LinkecList() - Initialize private variables ( May not be needed as it is an empty constructor. the Private variables can be initialised when declared.
         * 
         * Private Fields: these private fields do not need getters and setters coz they will not be accessed by the outside world. 
         * They are to be used within the class only.
         * [] Node _head - to store reference of the head node
         * [] int _size - lists the size of the list ie the number of elements in the list
         * 
         * Public properties:
         * [] bool Empty - bool to store list is empty or not
         * [] int Count - returns the size of the list
         * [] int Indexer - to access the elements of the list like an array
         * 
         * Methods:
         * [] Add(int index, object o) - Adds element at the speficied index
         * [] Add(object o) - Adds element at the last
         * [] Remove(int index) - Removes element at the specified index
         * [] Clear() - Clears the list ie removes all the elements
         * [] IndexOf(object o) - Gets the index of the specified element oe returns -1 if item not available.
         * [] Contains(object o) - Returns true/false if the element is found in the list
         * [] Get(int index) - Gets the element at the specied index
         * 
         */

        Node _head= null;
        int _size = 0;

        /// <summary>
        /// Empty method - checks whether the list is empty or not, returns true if empty
        /// </summary>
        public bool Empty
        {
            get { return _size == 0; }
        }

        /// <summary>
        /// Count method - returns the number of items in the list
        /// </summary>
        public int Count
        {
            get { return _size; }
        }

        /// <summary>
        /// Add method - Adds the new object at the index specified
        /// </summary>
        /// <param name="index"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public object Add(int index, object o)
        {
            if(index < 0)
            {
                throw new ArgumentOutOfRangeException("index - " + index);
            }

            if(index > _size)
            {
                index = _size;
            }

            Node current = _head;
            if(Empty || index == 0)
            {
                _head = new Node(o, _head);
            }
            else
            {
                for (int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(o, current.Next);

            }
            _size++;
            return o;
        }

        /// <summary>
        /// Add method - Adds the new object at the end of the list always
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public object Add(object o)
        {
            return Add(_size , o);
        }

        /// <summary>
        /// Removes an element at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object Remove(int index)
        {
            if(index < 0)
            {
                throw new ArgumentOutOfRangeException("index - " + index);
            }
            if(Empty)
            {
                return null;
            }
            if(index >= _size)
            {
                index = _size;
            }

            Node current = _head;
            object result = null;
            if(index == 0)
            {
                result = current.Data;
                _head = current.Next;
            }
            else
            {
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }

            _size--;

            return result ;
        }

        /// <summary>
        /// Clear method - Clears all the elements in the list
        /// </summary>
        public void Clear()
        {
            _head = null;
            _size = 0;
        }

        /// <summary>
        /// IndexOf method - Returns the index of the element specified for. If element does not exist in the list, returns -1
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int IndexOf(object o)
        {
            Node current = _head;
            for (int i = 0; i < _size ; i++)
            {
                if(current .Data .Equals(o))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        /// <summary>
        /// Contains method - Checks if the specified element is available in the list
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool  Contails(object o)
        {
            return IndexOf(o) >= 0;
        }

        public object Get(int index)
        {
            if(index < 0)
            {
                throw new  ArgumentOutOfRangeException("index - " + index);
            }
            if(Empty)
            {
                return null;
            }
            if(index >= _size)
            {
                index = _size - 1;
            }
            Node current = _head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

    }
}
