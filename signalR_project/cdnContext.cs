using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signalR_project
{
    public class cdnContext : DbContext
    {
        public DbSet<UserNotification> UserNotification { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=trbeo.database.windows.net;Database=BEO;User Id=appuser;Password=@ppuser@54321;Trusted_Connection=false;MultipleActiveResultSets=true");
        }
    }
}
