using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MyCenter.Shared.Entities;

namespace MyCenter.Backend.Data
{
    public class DataContext: DbContext
    {
        internal readonly object MyCenterComputer;
        internal readonly object MyComputer;

        public DataContext(DbContextOptions<DataContext> opcions) : base(opcions)
        {

        }

        public DbSet<Shared.Entities.MyCenter> CenterComputers { get; set; }

    }
}
