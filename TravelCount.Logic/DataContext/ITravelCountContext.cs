using System;
using System.Collections.Generic;
using System.Text;
using TravelCount.Logic.Entities.Persistence;

namespace TravelCount.Logic.DataContext
{
    internal interface ITravelCountContext
    {
        IEnumerable<Travel> Travels { get; set; }

        IEnumerable<Expense> Expenses { get; set; }
    }
}
