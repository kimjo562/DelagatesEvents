using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new list
            ListWithChangedEvent list = new ListWithChangedEvent();

            // Create a class that listens for when the list is changed
            EventListener listener = new EventListener(list);


            list.Add("hello");          // Everytime list is changed, print Notfication.    From: *Blank* to hello (Notify Change)
            list.Add("world");          // From: hello to world     (Notify Change)
            list.Clear();               // From: world to *Blank*   (Notify Change)
            listener.Detatch();


            Console.ReadKey();
        }
    }
}
