using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildList
{
    public class CustomList<T>
    {
        //member variables
        private int capacity = 5;
        private int count = 0;
        public T[] arr;
        //constructor
        public CustomList()
        {
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

            count++;
            if (count / capacity >= .5)
            {
                capacity = capacity * 2;
            }

             
            
        }




        //getters and setters 

        public int Count
        {
            get { return count; }
        }
    }
}
