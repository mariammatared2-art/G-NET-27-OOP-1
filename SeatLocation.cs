using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public struct SeatLocation
    {
        public int Row;
        public int Number;

        public SeatLocation(int row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString() => $"{Row}{Number}";
    }
}

