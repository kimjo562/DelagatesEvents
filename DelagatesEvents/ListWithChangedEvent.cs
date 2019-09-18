using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);
    public delegate void FizzBuzzEventHandler(object sender, EventArgs e);
    class ListWithChangedEvent : ArrayList
    {
        public ChangedEventHandler Changed;
        public FizzBuzzEventHandler fizz;
        public FizzBuzzEventHandler buzz;
        public FizzBuzzEventHandler fizzbuzz;

        protected virtual void OnChanged(EventArgs e)
        {
            Changed?.Invoke(this, e);
            //            if (Changed != null)
            //                Changed(this, e);
        }

        protected virtual void OnFizz(EventArgs e)
        {
            fizz?.Invoke(this, e);
        }

        protected virtual void OnBuzz(EventArgs e)
        {
            buzz?.Invoke(this, e);
        }

        protected virtual void OnFizzBuzz(EventArgs e)
        {
            fizzbuzz?.Invoke(this, e);
        }


        public void FizzBuzz()
        {
            for (int i = 0; i < Length; i++)
            {
                if ((int)this[i] % 3 == 0 && (int)this[i] % 5 == 0)
                {
                    Console.Write(this[i]);
                    OnFizzBuzz(EventArgs.Empty);
                }
                else if ((int)this[i] % 3 == 0)
                {
                    Console.Write(this[i]);
                    OnFizz(EventArgs.Empty);
                }
                else if ((int)this[i] % 5 == 0)
                {
                    Console.Write(this[i]);
                    OnBuzz(EventArgs.Empty);
                }
                else
                {
                    Remove(i);
                    i--;
                }
            }

        }

        public override void Add(object value)
        {
            base.Add(value);
            OnChanged(EventArgs.Empty);
        }

        public override void Remove(int index)
        {
            base.Remove(index);
            OnChanged(EventArgs.Empty);
        }

        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            get => base[index];

            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }

        }



    }

}
