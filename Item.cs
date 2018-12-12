using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoT_Tracker
{
    class Item
    {
        public int Index { get; }
        public int Value { get; set; }
        public int MaxValue { get; set; }

        public Item()
        {
            this.Value = 0;
            this.MaxValue = 1;
        }

        public void Increment()
        {
            if (this.Value < this.MaxValue)
                this.Value++;
            return;
        }

        public void Decrement()
        {
            if (this.Value > 0)
                this.Value--;
            return;
        }
    }
}