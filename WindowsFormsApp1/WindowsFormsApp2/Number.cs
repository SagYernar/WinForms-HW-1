using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Number
    {
        public int MyNumber { get; set; }
        public int Highest { get; set; }
        public int Lowest { get; set; }
        public int Count { get; set; }

        public Number()
        {
            MyNumber = 1000;
            Highest = 2001;
            Lowest = 0;
            Count = 0;
        }

        public void Bigger()
        {
            Lowest = MyNumber;
            if (MyNumber != Lowest + (Highest - Lowest) / 2)
            {
                MyNumber = Lowest + (Highest - Lowest) / 2;
                Count++;
            }
        }

        public void Lower()
        {
            Highest = MyNumber;
            if (MyNumber != Highest - (Highest - Lowest) / 2)
            {
                MyNumber = Highest - (Highest - Lowest) / 2;
                Count++;
            }
        }
    }
}
