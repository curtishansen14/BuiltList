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
            //CustomList<int> list = new CustomList<int>() { 1, 2 };
            //CustomList<int> list2 = new CustomList<int>() { 3, 4 };
            //CustomList<int> list3 = list + list2;
            //Console.WriteLine(list3);

            CustomList<string> list4 = new CustomList<string>() { "a", "b" };
            CustomList<string> list5 = new CustomList<string>() { "c", "d" };
            CustomList<string> list6 = list4 + list5;
            Console.WriteLine(list6);
            //Console.ReadKey();

            Widget widget = new Widget();
            Widget thing = new Widget();
            Widget doodad = new Widget();
            CustomList<Widget> list = new CustomList<Widget>() { thing, thing, thing };
            CustomList<Widget> list2 = new CustomList<Widget>() { widget, doodad, doodad, widget };

            CustomList<Widget> list3 = list + list2;
            Console.WriteLine(list3);
            Console.ReadKey();
        }

    }
}
