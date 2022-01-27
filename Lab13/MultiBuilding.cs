using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class MultiBuilding: Building
    {
        int floor;

        int Floor { get; set; }

        public MultiBuilding(string address, int lenght, int width, int height, int floor)
            :base(address, lenght, width, height)
        {
            this.Floor = floor;
        }
        public string Print()
        {
            string resalt=base.Print();
            resalt += $"{floor}";
            return resalt;
        }
    }
}
