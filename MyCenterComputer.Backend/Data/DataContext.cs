using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MyCenterComputer.Shared.Entities;

namespace MyCenterComputer.Backend.Data
{
    public class DataContext: DbContext
    {
        internal readonly object MyCenterComputer;
        internal readonly object MyComputer;

        public DataContext(DbContextOptions<DataContext> opcions) : base(opcions)
        {

        }

        public DbSet<MyCenter> CenterComputers { get; set; }

    }
}
