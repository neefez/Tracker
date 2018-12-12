using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoT_Tracker
{
    class Chest
    {
        public int Available;
        public bool Opened;
        public List<List<Item>> LogicReq = new List<List<Item>>();

        public Chest()
        {
            this.Available = 0;
            this.Opened = false;
        }

        public void CheckAvailable(List<Item> CurrentItems)
        {
            bool Avail = true;
            foreach (List<Item> ReqList in LogicReq)
            {                
                foreach (Item item in ReqList)
                {
                    if (!CurrentItems.Contains(item))
                        Avail = false;
                }
                if (Avail)
                {
                    Available = 1;
                    return;
                }
            }
        }
    }
}
