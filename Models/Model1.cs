namespace Assingnment_1_.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnections")
        {
        }

        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<Table2> Table2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table1>()
                .Property(e => e.Cars)
                .IsFixedLength();

            modelBuilder.Entity<Table1>()
                .Property(e => e.Bikes)
                .IsFixedLength();

            modelBuilder.Entity<Table1>()
                .Property(e => e.Trucks)
                .IsFixedLength();

            modelBuilder.Entity<Table1>()
                .HasOptional(e => e.Table11)
                .WithRequired(e => e.Table12);

            modelBuilder.Entity<Table2>()
                .Property(e => e.Trains)
                .IsFixedLength();

            modelBuilder.Entity<Table2>()
                .Property(e => e.Planes)
                .IsFixedLength();

            modelBuilder.Entity<Table2>()
                .Property(e => e.Rockets)
                .IsFixedLength();
        }
    }
}
