using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(44);
            list.Add(44);
            list.Add(44);
            list.Add(44);
            list.Add(44);
            list.Add(44);
            list.Add(1);
        }
    }
}
