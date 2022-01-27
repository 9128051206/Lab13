using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Building
    {
        string address; 
        int length;
        int width;
        int height;

       public int Length { get; set;}

       public int Width { get; set; }

       public int Height { get; set; }


        public Building(string address, int lenght, int width, int height)
        {
            this.address = address;
            this.Length=length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"{address} {length} {width} {height}";
        }

    }
}
