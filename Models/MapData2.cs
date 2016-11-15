namespace MapTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;


    public partial class MapData2 : DbContext
    {
        public MapData2()
            : base("name=MapData2")
        {
        }

        public virtual DbSet<Test2> Test2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test2>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Test2>()
                .Property(e => e.City)
                .IsFixedLength();
        }
    }
}
