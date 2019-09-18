using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class ArrayList
    {
        private object[] _list;

        public ArrayList()
        {
            _list = new object[0];
        }
        public virtual void Add(object value)
        {
            // Create a new array if Length + 1
            object[] newList = new object[_list.Length + 1];
            // Put the values of the old array into the new one
            for (int i = 0; i < _list.Length; i++)
            {
                newList[i] = _list[i];
            }
            // Put the new value at the end of the new array
            newList[newList.Length - 1] = value;
            // Sets the current array to the new array
            _list = newList;


        }

        public virtual void Remove(int index)
        {
            // Create a new array if Length - 1
            object[] newList = new object[_list.Length - 1];
            int noStack = 0;
            // Put the values of the old array into the new array
            for (int i = 0; i < _list.Length; i++)
            {
                if (i != index)
                {
                    newList[noStack] = _list[i];
                    noStack++;
                }

            }
            //Set the current array to the new array
            _list = newList;

        }

        public virtual void Clear()
        {
            _list = new object[0];

        }

        public virtual void PrintList()
        {
            foreach (object i in _list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public virtual object this[int index]
        {
            set
            {
                _list[index] = value;
            }
            get
            {
                return _list[index];
            }

        }

        public int Length
        {
            get
            {
                return _list.Length;
            }
        }
    }
}
