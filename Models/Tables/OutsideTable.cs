using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables.Contracts
{
    public class OutsideTable : Table
    {
        public OutsideTable(int tableNumber, int capacity)
            : base(tableNumber, capacity, 3.50m)
        {
        }
    }
}
