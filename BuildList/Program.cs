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
            //CustomList<bool> list = new CustomList<bool>() { true, false, true };
            //Console.WriteLine(list.ToString());
            //Console.Read();

            //Widget widget = new Widget('a');
            //Console.WriteLine(widget.ToString());
            //Console.ReadKey();

            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<bool> list2 = new CustomList<bool>() { true, false, true };
            Console.WriteLine(list);
            Console.WriteLine(list2);
            Console.WriteLine("1 2 3 4 5 ");
            Console.WriteLine("true false true ");
            Console.Read();
            

        }

    }
}
