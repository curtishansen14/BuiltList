using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildList
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        private int capacity;
        private int count;
        public T[] arr;

        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 5;
            arr = new T[capacity];
        }

        //indexer
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        //member methods 


        public void Add(T Input)
        {

            
            T[] result = new T[capacity];
            if ((decimal)count / capacity >= .5m)
            {
                capacity = capacity * 2;
            }

            for (int i = 0; i < count ; i++)
            {
                result[i] = arr[i];
            }

            result[count] = Input;
            
            arr = result;
            count++;


        }

        public bool Remove(T Input)
        {
            bool result = false;
            return result; 
        }


        //getters and setters 

        public int Count
        {
            get { return count; }
        }

        //IEnumerator
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }
            //Exception IndexOutOfBoundsException = new Exception();
            throw new IndexOutOfRangeException();
        }
    }
}
