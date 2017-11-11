using Kdtry.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Kdtry.DAL
{
    public class KdtryContext : DbContext
    {
        public KdtryContext():base("KdytryContext")
        {

        }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<DaylySummary> DaylySummaries{ get; set; }
        public DbSet<Notice> Notices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }


}