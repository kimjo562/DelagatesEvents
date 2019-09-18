using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5,6,15,30 };
            // Create a new list
            ListWithChangedEvent list = new ListWithChangedEvent();

            // Create a class that listens for when the list is changed
             EventListener listener = new EventListener(list);

            for (int i = 0; i < num.Length; i++)
            {
                list.Add(num[i]);
            }

            Console.WriteLine();
            list.PrintList();
            list.FizzBuzz();
            list.PrintList();

            list.Clear();          
            listener.Detatch();

            Console.ReadKey();

        }
    }
}
