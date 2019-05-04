namespace ITI.Smart.UI.EF2.CF
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'ModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ITI.Smart.UI.EF2.CF.ModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelContext' 
        // connection string in the application configuration file.
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<User> Users { get; set;}
        public virtual DbSet<UserVisits> UserVisits { get; set; }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Cover> Covers { get; set; }
        public virtual DbSet<Flag> Flags { get; set; }





        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasOptional(c => c.Book).WithRequired(b => b.City);

            modelBuilder.Entity<Cover>().Property(c => c.Code).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Book>().HasRequired(b => b.Cover).WithRequiredPrincipal(c => c.Book);

        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}