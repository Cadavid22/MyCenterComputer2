using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace MyCenterComputer.Backend.Data
{
    public class DataContext: DbContext
    {
        internal readonly object MyCenterComputer;
        internal readonly object MyComputer;

        public DataContext(DbContextOptions<DataContext> opcions) : base(opcions)
        {

        }

        public DbSet<MyCenterComputer> CenterComputers { get; set; }

    }
}
