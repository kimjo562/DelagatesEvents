using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesEvents
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);
    class ListWithChangedEvent : ArrayList
    {
        public ChangedEventHandler Changed;

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        public override void Add(object value)
        {
            base.Add(value);
            OnChanged(EventArgs.Empty);
        }

        public void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }

        }



    }

}
