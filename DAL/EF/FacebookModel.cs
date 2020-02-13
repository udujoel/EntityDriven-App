namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FacebookModel : DbContext
    {
        public FacebookModel()
            : base("name=FacebookModel")
        {
        }

        public virtual DbSet<testDB> testDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<testDB>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<testDB>()
                .Property(e => e.country)
                .IsUnicode(false);
        }
    }
}
