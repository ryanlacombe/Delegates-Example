using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new list
            ListWithChangedEvent list = new ListWithChangedEvent();

            //Create a class that listens for when the list is changed
            EventListener listener = new EventListener(list);

            list.Add("hello");
            list.Add("world");
            list.Clear();
            listener.Detatch();

            Console.ReadKey();
        }
    }
}
