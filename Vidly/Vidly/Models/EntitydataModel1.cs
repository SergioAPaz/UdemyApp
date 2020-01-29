namespace Vidly.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntitydataModel1 : DbContext
    {
        public EntitydataModel1()
            : base("name=EntitydataModel1")
        {
        }

        public  DbSet<Animal> Animals { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MembershipType> MemberShiptype { get; set; }
        public DbSet<Food> Foot { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
