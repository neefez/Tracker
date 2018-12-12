using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoT_Tracker
{
    class Area
    {
        public List<Chest> Contains = new List<Chest>();

        public int NumAccessible()
        {
            int Access = 0;
            foreach (Chest chest in Contains)
            {
                if (chest.Available == 1)
                    Access++;
            }
            return Access;
        }

        public int NumTotal()
        {
            return Contains.Count;
        }
    }
}
