using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildList
{
    public class CustomList<T>
    {
        public int count = 0;
        //Methods go here ie toString, Add, Remove, etc
        public T[] arr = new T[5];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

       public T Add(T Input)
        {

            count++; 
            return Input;
        }

        public int Count
        {
            get { return count; }
        }
    }
}
