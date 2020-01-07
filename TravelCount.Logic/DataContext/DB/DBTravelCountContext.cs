using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TravelCount.Contracts;
using TravelCount.Logic.Entities;
using TravelCount.Logic.Entities.Persistence;

namespace TravelCount.Logic.DataContext.DB
{
    internal class DBTravelCountContext : DbContext, IContext, ITravelCountContext
    {
        public IEnumerable<Travel> Travels => TravelSet;

        public IEnumerable<Expense> Expenses => ExpenseSet;

        public DbSet<Travel> TravelSet { get; set; }
        public DbSet<Expense> ExpenseSet { get; set; }
    }
}
