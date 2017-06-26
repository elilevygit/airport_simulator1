namespace DAL
{

    using Repository;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBContent : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public DBContent()
            : base("name=Model1")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
         public virtual DbSet<Plane> Planes { get; set; }
         public virtual DbSet<Station> Stations { get; set; }
         public virtual DbSet<DCAhistory> DCAhistorys { get; set; }
    }


}


































        // public virtual DbSet<Station> Stations { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
           
        //    modelBuilder.Entity<Plane>()
        //        .HasKey(e => e.Planeid);

           
        //    modelBuilder.Entity<Station>()
        //                .HasRequired(s => s.Plane)
        //                .WithRequiredPrincipal(ad => ad.);

        //}