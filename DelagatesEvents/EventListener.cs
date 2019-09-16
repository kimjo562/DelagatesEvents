using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesEvents
{
    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {            
            List = list;
            List.Changed += new ChangedEventHandler(OnListChanged);
        }

        public void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("List changed event received.");
        }

        public void Detatch()
        {
            List.Changed -= new ChangedEventHandler(OnListChanged);
            List = null;
        }

   
   
    }
}
